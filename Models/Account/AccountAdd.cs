namespace ActiveCampaign.Net.Models.Account
{
    public class AccountAdd
    {
        /// <summary>
        /// Subdomain name. Should not contain ".activehosted.com" part. Acceptable characters are A to Z, numbers and underscore. Example: 'mynewaccount'
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Client's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional custom domain name.
        /// </summary>
        public string Cname { get; set; }

        /// <summary>
        /// Client's email address. We will never send any emails to this inbox.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Email address that we can email regarding this account.
        /// </summary>
        public string Notification { get; set; }

        /// <summary>
        /// Plan ID. For a list of Plan IDs, use API call "account_plans".
        /// </summary>
        public int PlanId { get; set; }

        /// <summary>
        /// Language to be used by default. The default setting is "english". Possible values are "english", "spanish", "portuguese", "portuguese - brazil", "finnish", "german", "french", "danish", "dutch", "chinese", "italian", "turkish"
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Timezone to be used by default. The default setting is "America/Chicago". Possible values are listed at http://en.wikipedia.org/wiki/Zoneinfo
        /// </summary>
        public string Timezone { get; set; }
    }
}