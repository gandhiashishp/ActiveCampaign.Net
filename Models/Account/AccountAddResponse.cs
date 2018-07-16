using Newtonsoft.Json;

namespace ActiveCampaign.Net.Models.Account
{
    public class AccountAddResponse : Result
    {

        /// <summary>
        /// Name of the account just added. Example: 'youraccount.activehosted.com'
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Username for main admin in the account just added.This is always 'admin'
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Admin password for main admin user (username= admin). Example: 'GS4GH7'
        /// </summary>

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}