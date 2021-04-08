using AutoMapper;
using dental_sys.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.IO;
using System.Linq;

namespace dental_sys.service
{
    public class NotificationService
    {
        private readonly IMapper _mapper;
        public NotificationService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NotificationEntity, NotificationModel>();
            });
            _mapper = config.CreateMapper();

        }

        public PagingModel<NotificationModel> GetAllNotification(int pageIndex, int pageSize)
        {

            var url = CommonService.GetUrlApi();
            pageIndex -= 1;
            var result = new PagingModel<NotificationEntity>();
            var offset = pageIndex * pageSize;
            var client = new RestClient(url);
            var currentUserId = UserLoginModel.User.Id;
            var request = new RestRequest($"users/{currentUserId}/notifications?offset={offset}&limit={pageSize}", Method.GET);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content;
                result = JsonConvert.DeserializeObject<PagingModel<NotificationEntity>>(resultContent);
            }

            //result = DumbData(offset, pageSize);
            var no = offset + 1;
            var classModels = result.Data?.Select((a, ix) =>
            {
                var b = _mapper.Map<NotificationModel>(a);
                b.No = (no++).ToString();
                return b;
            });
            return new PagingModel<NotificationModel>
            { Data = classModels?.ToList(), Total = result.Total };
        }


        public int CountUnread()
        {

            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var currentUserId = UserLoginModel.User.Id;
            var request = new RestRequest($"users/{currentUserId}/notifications/count-unread", Method.GET);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Execute(request);
            CountUnreadEntity result = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultContent = response.Content;
                result = JsonConvert.DeserializeObject<CountUnreadEntity>(resultContent);
            }
            return result?.Total ?? 0;
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

        public bool UpdateReadNotification(string id)
        {
            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var currentUserId = UserLoginModel.User.Id;
            var request = new RestRequest($"users/{currentUserId}/notifications/{id}", Method.PUT);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public bool DeleteAllRead()
        {
            var url = CommonService.GetUrlApi();
            var client = new RestClient(url);
            var currentUserId = UserLoginModel.User.Id;
            var request = new RestRequest($"users/{currentUserId}/notifications/delete-all-read", Method.DELETE);
            request.AddHeader("Authorization", UserLoginModel.AccessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Charset", "utf-8");
            request.AddHeader("Connection", "close");
            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    }
}
