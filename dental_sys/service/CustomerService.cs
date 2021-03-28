using dental_sys.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.IO;

namespace dental_sys.service
{
    public class CustomerService
    {
        public ICollection<Customer> getAllCustomers(int pageIndex, int pageSize, string searchValue)
        {
            string path = System.Environment.CurrentDirectory;
            string url = File.ReadAllText($@"{path}\url");
            pageIndex = pageIndex - 1;
            ICollection<Customer> result = new List<Customer>();
            var client = new RestClient(url);
            var request = new RestRequest($"users?name={searchValue}&offset={pageIndex}&limit={pageSize}", Method.GET);
            var response = client.Get<ICollection<Customer>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content.ToString();
                result = JsonConvert.DeserializeObject<ICollection<Customer>>(resultContent);

            }
            return result;
        }
        public bool Update(int id, bool active)
        {
            string path = System.Environment.CurrentDirectory;
            string url = File.ReadAllText($@"{path}\url");
            var client = new RestClient(url);
            var request = new RestRequest($"users/{id}", Method.PUT);
            var body = new JObject();
            body.Add("is_active", active);
            var json = JsonConvert.SerializeObject(body);
            request.AddJsonBody(json);
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }
        //public bool Delete(string id)
        //{
        //    string path = System.Environment.CurrentDirectory;
        //    string url = File.ReadAllText($@"{path}\url");
        //    var client = new RestClient(url);
        //    var request = new RestRequest($"users/{id}", Method.GET);
        //    Customer data = new Customer();
        //    var response = client.Execute<Customer>(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        string resultContent = response.Content.ToString();
        //        data = JsonConvert.DeserializeObject<Customer>(resultContent);
        //    }
        //    data.IsActive = false;
        //    return Update(data);

        //}
        public Customer GetDetail(int id)
        {
            string path = System.Environment.CurrentDirectory;
            string url = File.ReadAllText($@"{path}\url");
            var client = new RestClient(url);
            var request = new RestRequest($"users/{id}", Method.GET);
            Customer data = new Customer();
            var response = client.Execute<Customer>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content.ToString();
                data = JsonConvert.DeserializeObject<Customer>(resultContent);
            }
            return data;

        }
        public Customer GetUrl()
        {
            var client = new RestClient("http://url-env.eba-rvk73mrv.ap-southeast-1.elasticbeanstalk.com");
            var request = new RestRequest("api/url/1", Method.GET);
            Customer data = new Customer();
            var response = client.Execute<UrlModel>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string content = response.Content.ToString();
                UrlModel url = JsonConvert.DeserializeObject<UrlModel>(content);
                string path = System.Environment.CurrentDirectory;
                File.WriteAllText($@"{path}\url", url.Url);
            }
            return data;

        }
    }
}
