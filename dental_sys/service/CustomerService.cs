using dental_sys.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;

namespace dental_sys.service
{
    public class CustomerService
    {
        private readonly IMapper _mapper;
        public CustomerService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerModel>()
                    .ForMember(destination => destination.UId,
                        opts => opts.MapFrom(source => source.UID)); ;
            });
            _mapper = config.CreateMapper();

        }
        public PagingModel<CustomerModel> GetAllCustomers(int pageIndex, int pageSize, string searchValue = null)
        {
            string path = System.Environment.CurrentDirectory;
            string url = File.ReadAllText($@"{path}\url");
            pageIndex = pageIndex - 1;
            var result = new PagingModel<Customer>();
            var offset = pageIndex * pageSize;
            var client = new RestClient(url);
            var request = new RestRequest($"users?name={searchValue}&offset={offset}&limit={pageSize}", Method.GET);
            var response = client.Get<ICollection<Customer>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content;
                result = JsonConvert.DeserializeObject<PagingModel<Customer>>(resultContent);
            }

            var no = 1;
            var customerModels = result.Data?.Select((a, ix) =>
            {
                var b = _mapper.Map<CustomerModel>(a);
                b.No = (no++).ToString();
                b.Status = b.IsActive ? "Active" : "Inactive";
                return b;
            });
            return new PagingModel<CustomerModel>
                { Data = customerModels?.ToList(), Total = result.Total };
        }
        public bool Update(string id, bool active)
        {
            string path = System.Environment.CurrentDirectory;
            string url = File.ReadAllText($@"{path}\url");
            var client = new RestClient(url);
            var request = new RestRequest($"users/{id}", Method.PUT);
            var body = new JObject { { "is_active", active } };
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
        public Customer GetDetail(string id)
        {
            string path = System.Environment.CurrentDirectory;
            string url = File.ReadAllText($@"{path}\url");
            var client = new RestClient(url);
            var request = new RestRequest($"users/{id}", Method.GET);
            Customer data = new Customer();
            var response = client.Execute<Customer>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content;
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
