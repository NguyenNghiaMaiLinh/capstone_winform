using dental_sys.model;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace dental_sys.service
{
    public class CustomerService
    {
        public static string URL = "https://ef1f960346ddce.localhost.run/api/";
        public ICollection<Customer> getAllCustomers(int pageIndex, int pageSize, string searchValue)
        {
            pageIndex = pageIndex - 1;
            ICollection<Customer> result = new List<Customer>();
            var client = new RestClient(URL);
            var request = new RestRequest("users", Method.GET);
            var response = client.Get<ICollection<Customer>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content.ToString();
                result = JsonConvert.DeserializeObject<ICollection<Customer>>(resultContent);

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    result = result.Where(c => c.Phone.Contains(searchValue) ||
                    c.Name.Contains(searchValue)).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                }
                else
                {
                    result = result.Skip(pageIndex * pageSize).Take(pageSize).ToList();
                }


            }
            return result;
        }
        public bool Update(Customer customer)
        {
            var client = new RestClient(URL);
            var request = new RestRequest($"users/{customer.Id}", Method.PUT);
            Customer result = new Customer();
            var json = JsonConvert.SerializeObject(customer);
            request.AddJsonBody(json);
            var response = client.Execute<Customer>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }
        public bool Delete(string id)
        {
            var client = new RestClient(URL);
            var request = new RestRequest($"users/{id}", Method.GET);
            Customer data = new Customer();
            var response = client.Execute<Customer>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string resultContent = response.Content.ToString();
                data = JsonConvert.DeserializeObject<Customer>(resultContent);
            }
            data.IsActive = false;
            return Update(data);

        }
    }
}
