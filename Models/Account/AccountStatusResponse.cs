using Newtonsoft.Json;

namespace ActiveCampaign.Net.Models.Account
{
    public class AccountStatusResponse : Result
    {
        /// <summary>
        /// A status message. Can be: active, disabled, creating, cancelled
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}