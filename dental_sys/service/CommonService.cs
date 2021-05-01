using System.IO;
using dental_sys.model;
using Newtonsoft.Json;
using RestSharp;

namespace dental_sys.service
{
    public static class CommonService
    {
        public static void SaveUrlApi()
        {
            var client = new RestClient("http://url-env.eba-rvk73mrv.ap-southeast-1.elasticbeanstalk.com");
            var request = new RestRequest("api/url/1", Method.GET);
            var response = client.Execute<UrlModel>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = response.Content;
                var url = JsonConvert.DeserializeObject<UrlModel>(content);
                var path = System.Environment.CurrentDirectory;
                File.WriteAllText($@"{path}\url", url.Url);
                url.Url = url.Url.Replace("http://", "");
                var end = url.Url.LastIndexOf(":");
                File.WriteAllText($@"{path}\train-url", url.Url.Substring(0, end));
                File.WriteAllText($@"{path}\detect-url", url.Url.Substring(0, end));
            }
        }

        public static string GetUrlApi()
        {
            var path = System.Environment.CurrentDirectory;
            var url = File.ReadAllText($@"{path}\url");
            return url;
        }
        public static string GetUrlDetectServer()
        {
            var path = System.Environment.CurrentDirectory;
            var url = File.ReadAllText($@"{path}\detect-url");
            return url;
        }
        public static string GetUrlApiTrainServer()
        {
            var path = System.Environment.CurrentDirectory;
            var url = File.ReadAllText($@"{path}\train-url");
            return url;
        }
    }
}
