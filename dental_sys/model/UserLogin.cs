using Newtonsoft.Json;

namespace dental_sys.model
{

    public class UserLoginModel
    {
        public static string AccessToken { get; set; }
        public static User User { get; set; }
    }
    public class UserLogin
    {
        [JsonProperty("token")]
        public string AccessToken { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
    }
    public class User
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
}
