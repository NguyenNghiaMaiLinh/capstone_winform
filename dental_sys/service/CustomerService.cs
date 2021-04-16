using AutoMapper;
using dental_sys.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Linq;

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
            var url = CommonService.GetUrlApi();
            pageIndex -= 1;
            var result = new PagingModel<Customer>();
            var offset = pageIndex * pageSize;
            var client = new RestClient(url);
           
            var request = new RestRequest($"users?name={searchValue}&offset={offset}&limit={pageSize}", Method.GET);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Get(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultContent = response.Content;
                result = JsonConvert.DeserializeObject<PagingModel<Customer>>(resultContent);
            }

            var no = offset + 1;
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
            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var request = new RestRequest($"users/{id}", Method.PUT);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var body = new JObject { { "is_active", active } };
            var json = JsonConvert.SerializeObject(body);
            request.AddJsonBody(json);
            var response = client.Put(request);
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
            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var request = new RestRequest($"users/{id}", Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            var data = new Customer();
            var response = client.Get(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultContent = response.Content;
                data = JsonConvert.DeserializeObject<Customer>(resultContent);
            }
            return data;
        }

    }
}
