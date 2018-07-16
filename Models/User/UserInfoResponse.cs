using Newtonsoft.Json;

namespace ActiveCampaign.Net.Models.User
{
    public class UserInfoResponse : Result
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}