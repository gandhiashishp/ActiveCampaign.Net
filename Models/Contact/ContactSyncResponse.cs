using Newtonsoft.Json;

namespace ActiveCampaign.Net.Models.Contact
{
    public class ContactSyncResponse : Result
    {
        /// <summary>
        /// The contact ID that was added or updated.
        /// </summary>
        [JsonProperty("subscriber_id")]
        public string SubscriberId { get; set; }
    }
}