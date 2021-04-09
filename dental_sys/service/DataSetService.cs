using dental_sys.Constants;
using dental_sys.model;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;

namespace dental_sys.service
{
    public class DataSetService
    {

        public DataSetService()
        {
        }

        public void TransferData(ICollection<ImageFileModel> data, ICollection<LabelFileModel> labelData)
        {
            var pk = new PrivateKeyFile(@"C:\Users\DELL.ssh\id_rsa");
            var folder = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            folder = folder.Replace("/", "").Replace(" ", "").Replace(":", "");
            var dataDir = $@"{ServerTrainConstant.TrainPath}/{UserLoginModel.User.Id}";
            using (var client = new SshClient(ServerTrainConstant.HostName, ServerTrainConstant.Username, pk))
            {
                client.Connect();
                var command = client.CreateCommand($@"cd {dataDir}  &&  mkdir -p {folder}");
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
                        client.Upload(file, $"{dataDir}/data");
                    }
                }

                foreach (var item in labelData)
                {
                    using (var file = File.OpenRead(item.Path))
                    {
                        client.Upload(file, $"{dataDir}/fixed_label");
                    }
                }
                client.Disconnect();
            }

        }


        public void TrainData()
        {
            var pk = new PrivateKeyFile(@"C:\Users\DELL.ssh\id_rsa");

            var trainDir = $@"{ServerTrainConstant.TrainPath}";
            using (var client = new SshClient(ServerTrainConstant.HostName, ServerTrainConstant.Username, pk))
            {
                client.Connect();
                var createDataCommand = client.CreateCommand($@"cd {trainDir} && label.py");
                createDataCommand.Execute();
                var command = client.CreateCommand($@"./darknet detector train yolo.data cfg/yolov4-custom.cfg backup/yolov4-custom_last.weights -dont_show -map -clear ");
                command.Execute();
                client.Disconnect();
            }
        }

        public void DownloadWeight(string url, string destinationFolder)
        {
            var pk = new PrivateKeyFile(@"C:\Users\DELL.ssh\id_rsa");
            var folder = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            var destination = new DirectoryInfo(destinationFolder);
            using (var client = new ScpClient(ServerTrainConstant.HostName, 22, ServerTrainConstant.Username, pk))
            {
                client.Connect();

                client.Download("file", destination);

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
                var command = client.CreateCommand($@"cd {trainDir} && cat IsTrain");

                command.Execute();
                result = command.Result;

                client.Disconnect();
            }

            return result == "1";
        }

    }
}
