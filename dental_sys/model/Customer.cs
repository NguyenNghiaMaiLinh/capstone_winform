using System.ComponentModel;
using dental_sys.Constants;
using Newtonsoft.Json;

namespace dental_sys.model
{
    public class Customer
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("avatar_url")]
        public string Url { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("role")]
        public int Role { get; set; }
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
        [JsonProperty("uid")]
        public string UID { get; set; }
    }
    public class UpdateCustomer
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class CustomerModel
    {
        [DisplayName(CustomerHeaderConstant.No)]
        public string No { get; set; }
        [Browsable(false)]
        public string UId { get; set; }
        [DisplayName(CustomerHeaderConstant.Name)]
        public string Name { get; set; }
        [DisplayName(CustomerHeaderConstant.Phone)]
        public string Phone { get; set; }
        [DisplayName(CustomerHeaderConstant.Email)]
        public string Email { get; set; }
        [DisplayName(CustomerHeaderConstant.Status)]
        public string Status { get; set; }
        [Browsable(false)]
        public string Url { get; set; }
        [Browsable(false)]
        public bool IsActive { get; set; }
        [Browsable(false)]
        public int Role { get; set; }
        [Browsable(false)]
        public string Id { get; set; }
    }
}
