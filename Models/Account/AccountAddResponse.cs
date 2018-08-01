namespace ActiveCampaign.Net.Models.Account
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines the <see cref="AccountAddResponse" />
    /// </summary>
    public class AccountAddResponse : Result
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Account
        /// Name of the account just added. Example: 'youraccount.activehosted.com'
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the Password
        /// Admin password for main admin user (username= admin). Example: 'GS4GH7'
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Username
        /// Username for main admin in the account just added.This is always 'admin'
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        #endregion
    }
}