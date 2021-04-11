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
        public const string HostName = "192.168.1.34";
        public const string DarknetPath = "/home/dev/darknet";
        public const string BackupPath = "/home/dev/darknet/backup";
        public const string TrainPath = "/home/dev/darknet/train";
        public const string PrivateKeyFilePath = @"C:\Users\DELL\.ssh\id_rsa";
    }
}
