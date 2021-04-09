using AutoMapper;
using dental_sys.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dental_sys.service
{
    public class WeightService
    {
        private readonly IMapper _mapper;
        public WeightService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<WeightVersionEntity, WeightVersionModel>();
            });
            _mapper = config.CreateMapper();

        }

        private PagingModel<WeightVersionEntity> DumbData(int offset, int pageSize)
        {
            var result = new List<WeightVersionEntity>();
            var rand = new Random();
            for (var i = 0; i < 100; i++)
            {
                result.Add(new WeightVersionEntity()
                {
                    ClassVersionId = i.ToString(),
                    CreatedDate = DateTime.Now,
                    Id = i.ToString(),
                    IsActive = rand.Next(0, 2) == 1,
                    Url = Guid.NewGuid().ToString("N"),
                    Version = Guid.NewGuid().ToString("N")
                });
            }

            return new PagingModel<WeightVersionEntity>() { Data = result.Skip(offset).Take(pageSize).ToList(), Total = 99 };
        }


        public PagingModel<WeightVersionModel> GetAllWeightByClassId(string classId, int pageIndex, int pageSize, string searchValue = null)
        {

            var url = CommonService.GetUrlApi();
            pageIndex -= 1;
            var result = new PagingModel<WeightVersionEntity>();
            var offset = pageIndex * pageSize;
            var client = new RestClient(url);
            var request = new RestRequest($"versions/{classId}/weights?version={searchValue}&offset={offset}&limit={pageSize}", Method.GET);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content;
                result = JsonConvert.DeserializeObject<PagingModel<WeightVersionEntity>>(resultContent);
            }

            //result = DumbData(offset, pageSize);
            var no = offset + 1;
            var weightModels = result.Data?.Select((a, ix) =>
            {
                var b = _mapper.Map<WeightVersionModel>(a);
                b.No = (no++).ToString();
                b.Status = b.IsActive ? "Active" : "Inactive";
                return b;
            });
            return new PagingModel<WeightVersionModel>
            { Data = weightModels?.ToList(), Total = result.Total };
        }

        public bool Update(WeightVersionEntity entity)
        {
            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var request = new RestRequest($"versions/{entity.ClassVersionId}/weights/{entity.Id}", Method.PUT);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var body = JObject.FromObject(entity);
            request.AddJsonBody(body.ToString());
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
        public bool Create(string classId, string path)
        {
            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var request = new RestRequest($"versions/{classId}/weights", Method.POST);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            request.AddFile("file", path);
            var response = client.Execute<Customer>(request);

            return response.StatusCode == System.Net.HttpStatusCode.Created;
        }

        public WeightVersionModel GetWeightVersion(string classId)
        {

            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var request = new RestRequest($"versions/{classId}/weights/weight-get-last-version", Method.GET);
            WeightVersionModel result = null;
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Execute<Customer>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultContent = response.Content;
                var data = JsonConvert.DeserializeObject<WeightVersionEntity>(resultContent);
                result = _mapper.Map<WeightVersionModel>(data);
            }

            return result;

        }
    }
}
