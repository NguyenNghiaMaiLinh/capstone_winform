using dental_sys.Constants;
using dental_sys.model;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Microsoft.Owin.Logging;
using Microsoft.VisualBasic.Logging;

namespace dental_sys.service
{
    public class DataSetService
    {

        public DataSetService()
        {
        }

        public bool TransferData(ICollection<ImageFileModel> data, ICollection<LabelFileModel> labelData, bool isClearData = false)
        {
            try
            {
                var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
                var folder = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat);
                folder = folder.Replace("/", "").Replace(" ", "").Replace(":", "");
                var dataFolder = $"train/admin/{UserLoginModel.User.Id}/data/{folder}";
                var labelFolder = $"train/admin/{UserLoginModel.User.Id}/label/{folder}";
                var dataDir = $@"{ServerTrainConstant.DarknetPath}";
                var trainDir = ServerTrainConstant.TrainPath;
                var trainServer = CommonService.GetUrlApiTrainServer();


                using (var client = new SshClient(trainServer, ServerTrainConstant.Username, pk))
                {
                    client.Connect();

                    if (isClearData)
                    {
                        var deleteDataCommand = client.CreateCommand($@"cd {trainDir}; rm -r admin ");
                        deleteDataCommand.Execute();
                    }

                    var command = client.CreateCommand($@"cd {dataDir}  &&  mkdir -pm 0777 {dataFolder} &&  mkdir -pm 0777 {labelFolder}");
                    command.Execute();
                    var result = command.Result;
                    Console.WriteLine(result);

                    client.Disconnect();
                }



                using (var client = new ScpClient(trainServer, 22, ServerTrainConstant.Username, pk))
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
            catch
            {
                return false;
            }

            return true;
        }


        public bool TrainData(string cfgPath)
        {
            try
            {

                var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
                var url = CommonService.GetUrlApi();
                var trainDir = ServerTrainConstant.TrainPath;
                var darknetDir = ServerTrainConstant.DarknetPath;
                var datetime = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat).Replace("/", "").Replace(" ", "").Replace(":", "");
                var weightPath = $@"backup/{UserLoginModel.User.Id}/{datetime}";
                var logPath = $@"backup/{UserLoginModel.User.Id}/{datetime}/train.log";
                var lossPath = $@"backup/{UserLoginModel.User.Id}/{datetime}/chart.png";
                var cfgFileName = Path.GetFileName(cfgPath);
                var trainServer = CommonService.GetUrlApiTrainServer();
                using (var client = new ScpClient(trainServer, 22, ServerTrainConstant.Username, pk))
                {
                    client.Connect();

                    using (var file = File.OpenRead(cfgPath))
                    {
                        client.Upload(file, $"{darknetDir}/yolo.cfg");
                    }

                    client.Disconnect();
                }


                using (var client = new SshClient(trainServer, ServerTrainConstant.Username, pk))
                {
                    client.Connect();
                    var createIsTrainCommand = client.CreateCommand($@"cd {trainDir} && echo ""1"" > istrain.txt");
                    createIsTrainCommand.Execute();
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
                    var command = client.CreateCommand($@"screen -dm bash -c 'cd {darknetDir};"
                                                       + $"./darknet detector train yolo.data yolo.cfg -dont_show > {logPath};"
                                                       + $"cp chart.png {lossPath};"
                                                       + $"python3 sendnoti.py --id {UserLoginModel.User.Id} --authen {UserLoginModel.AccessToken} --url {url} --backup {weightPath}/yolo_final.weights --log_path {logPath} --loss_function_path {lossPath};"
                                                       + $"cd {trainDir}; rm -r istrain.txt; rm -r admin '");
                    //var command = client.CreateCommand($@"screen -dm bash -c 'cd /home/dev/darknet; python sendnoti.py ""$--id {UserLoginModel.User.Id}"" --authen {UserLoginModel.AccessToken} --url {url}");
                    command.Execute();
                    client.Disconnect();
                }
            }
            catch (Exception e)
            {
                ExceptionLogging.SendErrorToText(e, nameof(this.TrainData), nameof(DataSetService));
                return false;
            }


            return true;
        }

        public bool DownloadWeight(NotificationModel notification, string destinationFolder)
        {
            try
            {
                var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
                //var folder = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat);
                var destination = new DirectoryInfo(destinationFolder);
                var weightPath = $"{ServerTrainConstant.DarknetPath}/{notification.Url}";
                var logPath = $"{ServerTrainConstant.DarknetPath}/{notification.LogPath}";
                var lossPath = $"{ServerTrainConstant.DarknetPath}/{notification.LossFunctionPath}";
                var trainServer = CommonService.GetUrlApiTrainServer();
                using (var client = new ScpClient(trainServer, 22, ServerTrainConstant.Username, pk))
                {
                    client.Connect();

                    client.Download(weightPath, destination);
                    client.Download(logPath, destination);
                    client.Download(lossPath, destination);

                    client.Disconnect();
                }

                using (var client = new SshClient(trainServer, ServerTrainConstant.Username, pk))
                {
                    client.Connect();


                    var deleteDataCommand = client.CreateCommand($@"rm -r {weightPath}; rm -r {logPath};rm -r {lossPath}");
                    deleteDataCommand.Execute();

                    client.Disconnect();
                }
            }
            catch (Exception e)
            {
                ExceptionLogging.SendErrorToText(e, nameof(this.DownloadWeight), nameof(DataSetService));
                return false;
            }
            return true;
        }

        public bool DownloadLog(NotificationModel notification, string destinationFolder)
        {
            try
            {
                var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
                //var folder = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat);
                var destination = new DirectoryInfo(destinationFolder);
                var logPath = $"{ServerTrainConstant.DarknetPath}/{notification.LogPath}";
                var lossPath = $"{ServerTrainConstant.DarknetPath}/{notification.LossFunctionPath}";
                var trainServer = CommonService.GetUrlApiTrainServer();
                using (var client = new ScpClient(trainServer, 22, ServerTrainConstant.Username, pk))
                {
                    client.Connect();

                    client.Download(logPath, destination);
                    client.Download(lossPath, destination);

                    client.Disconnect();
                }
            }
            catch (Exception e)
            {
                ExceptionLogging.SendErrorToText(e, nameof(this.DownloadWeight), nameof(DataSetService));
                return false;
            }
            return true;
        }

        public bool IsTraining()
        {
            try
            {
                var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
                var result = "";
                var trainDir = $@"{ServerTrainConstant.TrainPath}";
                var trainServer = CommonService.GetUrlApiTrainServer();
                using (var client = new SshClient(trainServer, ServerTrainConstant.Username, pk))
                {
                    client.Connect();
                    var command = client.CreateCommand($@"cd {trainDir} && cat istrain.txt");

                    command.Execute();
                    result = command.Result;

                    client.Disconnect();
                }

                return result.Contains("1");
            }
            catch (Exception e)
            {
                ExceptionLogging.SendErrorToText(e, nameof(this.IsTraining), nameof(DataSetService));
                throw;
            }
        }

        public void ApplyWeight(string weightPath)
        {
            var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
            var weightDir = ServerDetectConstant.WeightPath;
            var apiDir = ServerDetectConstant.ApiPath;
            var filename = Path.GetFileName(weightPath);
            var detectSertver = CommonService.GetUrlDetectServer();
            using (var client = new SshClient(detectSertver, ServerTrainConstant.Username, pk))
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
        public bool DownloadLogAndLoss(WeightVersionModel weight, string destinationFolder)
        {
            try
            {
                if (string.IsNullOrEmpty(weight.LogPath) || string.IsNullOrEmpty(weight.LossFunctionPath))
                {
                    return false;
                }
                var pk = new PrivateKeyFile(ApplicationConstant.PrivateKeyFilePath);
                //var folder = DateTime.Now.ToString(ApplicationConstant.DatetimeFormat);
                var destination = new DirectoryInfo(destinationFolder);
                var logPath = $"{ServerDetectConstant.ApiPath}/{weight.LogPath}";
                var lossPath = $"{ServerDetectConstant.ApiPath}/{weight.LossFunctionPath}";
                var detectSertver = CommonService.GetUrlDetectServer();
                using (var client = new ScpClient(detectSertver, 22, ServerTrainConstant.Username, pk))
                {
                    client.Connect();

                    client.Download(logPath, destination);
                    client.Download(lossPath, destination);

                    client.Disconnect();
                }

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
