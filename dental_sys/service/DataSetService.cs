using dental_sys.Constants;
using dental_sys.model;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
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
            var pk = new PrivateKeyFile(ServerTrainConstant.PrivateKeyFilePath);
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
            var pk = new PrivateKeyFile(ServerTrainConstant.PrivateKeyFilePath);
            var url = CommonService.GetUrlApi();
            var trainDir = ServerTrainConstant.TrainPath;
            var darknetDir = ServerTrainConstant.DarknetPath;
            using (var client = new SshClient(ServerTrainConstant.HostName, ServerTrainConstant.Username, pk))
            {
                client.Connect();
                var createIsTrainComannd = client.CreateCommand($@"cd {trainDir} && echo ""1"" > istrain.txt");
                createIsTrainComannd.Execute();
                var createDataCommand = client.CreateCommand($@"cd {trainDir} && mkdir -pm 0777 data && python3 label.py");
                createDataCommand.Execute();
                var createDataTextCommand = client.CreateCommand($@"cd {trainDir} && cd .. && python3 traindata.py && cd {darknetDir}");
                createDataTextCommand.Execute();
                //var guid = Guid.NewGuid().ToString("screen -dm bash -c 'cd /home/dev/darknet; python3 sendnoti.py --id 35 --authen eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpZCI6IlF3alZLbnF0WXhUMGhvQWJsVzVzOTVJWlJaQTMiLCJleHAiOjE2NDkyNDYxMzN9.9MpdU7fw2QUUQt1-1KtmKGugYPpNguY2vqkaGQMqBWc --url http://192.168.0.4:8080/api'");
                //var command = client.CreateCommand($@"screen -dm bash -c 'cd /home/dev/darknet; ./darknet detector train yolo.data yolo.cfg -dont_show'; curl --location --request POST --header 'Authorization: {UserLoginModel.AccessToken}' --header 'Content-Type: application/json' --data-raw '{{""user"":{UserLoginModel.User.Id},""message"":""Train complete"",""url"":""backup""}}' ""{url}/users/30/notifications""");
                var command = client.CreateCommand($@"screen -dm bash -c 'cd /home/dev/darknet; ./darknet detector train yolo.data yolo.cfg -dont_show; python3 sendnoti.py --id {UserLoginModel.User.Id} --authen {UserLoginModel.AccessToken} --url {url}; cd {trainDir}; rm -r istrain.txt '");
                //var command = client.CreateCommand($@"screen -dm bash -c 'cd /home/dev/darknet; python sendnoti.py ""$--id {UserLoginModel.User.Id}"" --authen {UserLoginModel.AccessToken} --url {url}");
                command.Execute();
                client.Disconnect();
            }
        }

        public void DownloadWeight(string url, string destinationFolder)
        {
            var pk = new PrivateKeyFile(ServerTrainConstant.PrivateKeyFilePath);
            //var folder = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat);
            var destination = new DirectoryInfo(destinationFolder);
            var backupPath = ServerTrainConstant.BackupPath;
            using (var client = new ScpClient(ServerTrainConstant.HostName, 22, ServerTrainConstant.Username, pk))
            {
                client.Connect();

                client.Download(backupPath, destination);

                client.Disconnect();
            }
        }

        public bool IsTraining()
        {
            var pk = new PrivateKeyFile(ServerTrainConstant.PrivateKeyFilePath);
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

    }
}
