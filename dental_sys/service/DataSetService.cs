using dental_sys.Constants;
using dental_sys.model;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace dental_sys.service
{
    public class DataSetService
    {

        public DataSetService()
        {
        }

        public void TransferData(ICollection<ImageFileModel> data, ICollection<LabelFileModel> labelData)
        {
            var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
            var folder = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat);
            folder = folder.Replace("/", "").Replace(" ", "").Replace(":", "");
            var dataFolder = $"train/admin/{UserLoginModel.User.Id}/data/{folder}";
            var labelFolder = $"train/admin/{UserLoginModel.User.Id}/label/{folder}";
            var dataDir = $@"{ServerTrainConstant.DarknetPath}";
            using (var client = new SshClient(ServerTrainConstant.HostName, ServerTrainConstant.Username, pk))
            {
                client.Connect();

                var command = client.CreateCommand($@"cd {dataDir}  &&  mkdir -pm 0777 {dataFolder} &&  mkdir -pm 0777 {labelFolder}");
                command.Execute();
                var result = command.Result;
                Console.WriteLine(result);

                client.Disconnect();
            }

            using (var client = new ScpClient(ServerTrainConstant.HostName, 22, ServerTrainConstant.Username, pk))
            {
                client.Connect();
                foreach (var item in data)
                {
                    using (var file = File.OpenRead(item.Path))
                    {
                        client.Upload(file, $"{dataDir}/{dataFolder}/{Path.GetFileName(item.Path)}");
                    }
                }

                foreach (var item in labelData)
                {
                    using (var file = File.OpenRead(item.Path))
                    {
                        client.Upload(file, $"{dataDir}/{labelFolder}/{Path.GetFileName(item.Path)}");
                    }
                }
                client.Disconnect();
            }

        }


        public void TrainData()
        {
            var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
            var url = CommonService.GetUrlApi();
            var trainDir = ServerTrainConstant.TrainPath;
            var darknetDir = ServerTrainConstant.DarknetPath;
            var datetime = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat).Replace("/", "").Replace(" ", "").Replace(":", "");
            var weightPath = $@"backup/{UserLoginModel.User.Id}/{datetime}";
            using (var client = new SshClient(ServerTrainConstant.HostName, ServerTrainConstant.Username, pk))
            {
                client.Connect();
                var createIsTrainComannd = client.CreateCommand($@"cd {trainDir} && echo ""1"" > istrain.txt");
                createIsTrainComannd.Execute();
                var createDataCommand = client.CreateCommand($@"cd {trainDir} && mkdir -pm 0777 data && python3 label.py");
                createDataCommand.Execute();
                var createDataTextCommand = client.CreateCommand($@"cd {trainDir} && cd .. && python3 traindata.py");
                createDataTextCommand.Execute();

                var createWeightsPath = client.CreateCommand($@"cd {darknetDir} && mkdir -pm 0777 {weightPath}");
                createWeightsPath.Execute();

                var createCfgFile = client.CreateCommand($@"cd {darknetDir} && python3 create_cfg.py --backup {weightPath}");
                createCfgFile.Execute();
                //var guid = Guid.NewGuid().ToString("screen -dm bash -c 'cd /home/dev/darknet; python3 sendnoti.py --id 35 --authen eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpZCI6IlF3alZLbnF0WXhUMGhvQWJsVzVzOTVJWlJaQTMiLCJleHAiOjE2NDkyNDYxMzN9.9MpdU7fw2QUUQt1-1KtmKGugYPpNguY2vqkaGQMqBWc --url http://192.168.0.4:8080/api'");
                //var command = client.CreateCommand($@"screen -dm bash -c 'cd /home/dev/darknet; ./darknet detector train yolo.data yolo.cfg -dont_show'; curl --location --request POST --header 'Authorization: {UserLoginModel.AccessToken}' --header 'Content-Type: application/json' --data-raw '{{""user"":{UserLoginModel.User.Id},""message"":""Train complete"",""url"":""backup""}}' ""{url}/users/30/notifications""");
                var command = client.CreateCommand($@"screen -dm bash -c 'cd /home/dev/darknet; ./darknet detector train yolo.data yolo.cfg -dont_show; python3 sendnoti.py --id {UserLoginModel.User.Id} --authen {UserLoginModel.AccessToken} --url {url} --backup {weightPath}/yolo_final.weights; cd {trainDir}; rm -r istrain.txt '");
                //var command = client.CreateCommand($@"screen -dm bash -c 'cd /home/dev/darknet; python sendnoti.py ""$--id {UserLoginModel.User.Id}"" --authen {UserLoginModel.AccessToken} --url {url}");
                command.Execute();
                client.Disconnect();
            }
        }

        public void DownloadWeight(string url, string destinationFolder)
        {
            var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
            //var folder = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat);
            var destination = new DirectoryInfo(destinationFolder);
            var backupPath = $"{ServerTrainConstant.DarknetPath}/{url}";
            using (var client = new ScpClient(ServerTrainConstant.HostName, 22, ServerTrainConstant.Username, pk))
            {
                client.Connect();

                client.Download(backupPath, destination);

                client.Disconnect();
            }
        }

        public bool IsTraining()
        {
            var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
            var result = "";
            var trainDir = $@"{ServerTrainConstant.TrainPath}";
            using (var client = new SshClient(ServerTrainConstant.HostName, ServerTrainConstant.Username, pk))
            {
                client.Connect();
                var command = client.CreateCommand($@"cd {trainDir} && cat istrain.txt");

                command.Execute();
                result = command.Result;

                client.Disconnect();
            }

            return result.Contains("1");
        }

        public void ApplyWeight(string weightPath)
        {
            var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
            var weightDir = ServerDetectConstant.WeightPath;
            var apiDir = ServerDetectConstant.ApiPath;
            var filename = Path.GetFileName(weightPath);
            using (var client = new SshClient(ServerTrainConstant.HostName, ServerTrainConstant.Username, pk))
            {
                client.Connect();

                var command = client.CreateCommand($@"cp {apiDir}/{weightPath} {weightDir}");
                command.Execute();

                var stopServerCommand = client.CreateCommand($@"pkill -f runserver");
                stopServerCommand.Execute();

                var renameCommand = client.CreateCommand($@"mv {weightDir}/{filename} {weightDir}/latest.weights");
                renameCommand.Execute();

                var restartCommand = client.CreateCommand($@"screen -dm bash -c 'cd {apiDir}; source $HOME/.profile; GOOGLE_APPLICATION_CREDENTIALS=solveequation-firebase.json poetry run python manage.py runserver 0.0.0.0:8080'");
                restartCommand.Execute();
                client.Disconnect();
            }
        }
    }
}
