using Newtonsoft.Json;

namespace ActiveCampaign.Net.Models
{
    public class Result
    {

        /// <summary>
        /// Whether or not the response was successful.Examples: 1 = yes, 0 = no
        /// </summary>
        [JsonProperty("result_code")]
        public int ResultCode { get; set; }

        /// <summary>
        /// A custom message that appears explaining what happened. Example: Account added
        /// </summary>
        [JsonProperty("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// The result output used.Example: serialize
        /// </summary>
        [JsonProperty("result_output")]
        public string ResultOutput { get; set; }
    }
}