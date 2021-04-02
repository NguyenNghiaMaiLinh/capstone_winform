using System;
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
    public class ClassVersionService
    {
        private readonly IMapper _mapper;
        public ClassVersionService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClassVersionEntity, ClassVersionModel>();
            });
            _mapper = config.CreateMapper();

        }

        private PagingModel<ClassVersionEntity> DumbData(int offset, int pageSize)
        {
            var result = new List<ClassVersionEntity>();
            var rand = new Random();
            for (var i = 0; i < 100; i++)
            {
                result.Add(new ClassVersionEntity()
                {
                    CreatedDate = DateTime.Now,
                    Id = i.ToString(),
                    CommitHash = Guid.NewGuid().ToString("N"),
                    Version = Guid.NewGuid().ToString("N")
                });
            }

            return new PagingModel<ClassVersionEntity>() { Data = result.Skip(offset).Take(pageSize).ToList(), Total = 99 };
        }


        public PagingModel<ClassVersionModel> GetAllClassVersion(int pageIndex, int pageSize, string searchValue = null)
        {

            var url = CommonService.GetUrlApi();
            pageIndex -= 1;
            var result = new PagingModel<ClassVersionEntity>();
            var offset = pageIndex * pageSize;
            var client = new RestClient(url);
            var request = new RestRequest($"versions?version={searchValue}&offset={offset}&limit={pageSize}", Method.GET);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content;
                result = JsonConvert.DeserializeObject<PagingModel<ClassVersionEntity>>(resultContent);
            }

            //result = DumbData(offset, pageSize);
            var no = offset + 1;
            var classModels = result.Data?.Select((a, ix) =>
            {
                var b = _mapper.Map<ClassVersionModel>(a);
                b.No = (no++).ToString();
                return b;
            });
            return new PagingModel<ClassVersionModel>
            { Data = classModels?.ToList(), Total = result.Total };
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
    }
}
