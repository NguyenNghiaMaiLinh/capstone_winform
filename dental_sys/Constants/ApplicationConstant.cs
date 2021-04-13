using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys.Constants
{
    public class ApplicationConstant
    {
        public const string DatetimeFormat = "dd/MM/yyyy HH:mm:ss";
        public const string PrivateKeyFilePath = @"C:\Users\Adminstrator\.ssh\id_rsa";
    }
    public class Order
    {
        public const string Asc = "Asc";
        public const string Desc = "Desc";
    }

    public class PagingConstant
    {
        public const int PageIndex = 1;
        public const int PageSize = 20;
    }

    public class ServerTrainConstant
    {
        public const string Username = "dev";
        public const string HostName = "192.168.0.4";
        public const string DarknetPath = "/home/dev/darknet";
        public const string BackupPath = "/home/dev/darknet/backup";
        public const string TrainPath = "/home/dev/darknet/train";
        
    }

    public class ServerDetectConstant
    {
        public const string Username = "dev";
        public const string HostName = "192.168.0.4";
        public const string DarknetPath = "/home/dev/darknet";
        public const string ApiPath = "/home/dev/detectserver/darknet/api";
        public const string WeightPath = "/home/dev/detectserver/darknet/api/weights";
    }
}
