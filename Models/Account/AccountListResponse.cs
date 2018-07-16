using System.Collections.Generic;
using Newtonsoft.Json;

namespace ActiveCampaign.Net.Models.Account
{
    public class Account
    {
        /// <summary>
        /// Subdomain name. Should not contain ".activehosted.com" part. Acceptable characters are A to Z, numbers and underscore. Example: 'mynewaccount'
        /// </summary>
        [JsonProperty("account")]
        public string AccountName { get; set; }

        /// <summary>
        /// Optional custom domain name. Example: mynewaccount.mydomain.com
        /// </summary>
        [JsonProperty("cname")]
        public string Cname { get; set; }

        /// <summary>
        /// Plan ID (For a list of Plan IDs, use API call "account_plans"). Example: 2
        /// </summary>
        [JsonProperty("planid")]
        public string PlanId { get; set; }

        /// <summary>
        /// Client's name.
        /// </summary>
        [JsonProperty("client_name")]
        public string ClientName { get; set; }

        /// <summary>
        /// Client's email address. We will never send any emails to this inbox.
        /// </summary>
        [JsonProperty("client_email")]
        public string ClientEmail { get; set; }

        /// <summary>
        /// Email address that we can email regarding this account.
        /// </summary>
        [JsonProperty("notification")]
        public string Notification { get; set; }

        /// <summary>
        /// The amount of subscribers in the account.
        /// </summary>
        [JsonProperty("subscribers")]
        public string Subscribers { get; set; }

        /// <summary>
        /// The amount of emails sent in this billing cycle.
        /// </summary>
        [JsonProperty("emails_sent")]
        public string EmailsSent { get; set; }

        /// <summary>
        /// Expiration date. Example: 2012-10-17
        /// </summary>
        [JsonProperty("expire")]
        public string Expire { get; set; }

        /// <summary>
        /// Whether the account is expired or not. 0=active, 1=expired
        /// </summary>
        [JsonProperty("expired")]
        public string Expired { get; set; }

        /// <summary>
        /// Custom status for this account set by reseller. 0=active, 1=inactive
        /// </summary>
        [JsonProperty("reseller_status")]
        public string ResellerStatus { get; set; }

    }
    public class AccountListResponse : Result
    {
        [JsonProperty("accounts")]
        public List<Account> Accounts { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }
}