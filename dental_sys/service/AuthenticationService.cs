using dental_sys.model;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace dental_sys.service
{
    public class AuthenticationService
    {
        public UserLogin GetToken(string uid)
        {
            var url = CommonService.GetUrlApi();
            UserLogin result = null;
            var client = new RestClient(url);
            var request = new RestRequest($"users", Method.POST, DataFormat.Json);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var body = new { uid };
            request.AddJsonBody(body);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var resultContent = response.Content;
                result = JsonConvert.DeserializeObject<UserLogin>(resultContent);
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                result = new UserLogin()
                {
                    ErrorMessage = JsonConvert.DeserializeObject<string>(response.Content)
                };
            }
            return result;
        }

    }
}
