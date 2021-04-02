using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dental_sys.model;
using Newtonsoft.Json;
using RestSharp;

namespace dental_sys.service
{
    public class AuthenticationService
    {
        public UserLogin GetToken(string uid)
        {
            var url = CommonService.GetUrlApi();
            UserLogin result = null;
            var client = new RestClient(url);
            var request = new RestRequest($"users", Method.POST);
            var body = new { uid };
            request.AddJsonBody(body);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultContent = response.Content;
                result = JsonConvert.DeserializeObject<UserLogin>(resultContent);
            }

            return result;
        }

    }
}
