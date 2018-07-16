using System.Collections.Generic;
using Newtonsoft.Json;

namespace ActiveCampaign.Net.Models.Account
{
    public class Plan
    {

        /// <summary>
        /// Plan ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Plan duration in months.Yearly plans have 12 here, monthly 1, etc.
        /// </summary>
        [JsonProperty("term")]
        public int Term { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tier")]
        public int Tier { get; set; }

        /// <summary>
        /// Plan price.
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }

        /// <summary>
        /// Plan price (formatted style).
        /// </summary>
        [JsonProperty("price_formatted")]
        public string PriceFormatted { get; set; }

        /// <summary>
        /// Emails sent limit for this plan.
        /// </summary>
        [JsonProperty("limit_mail")]
        public int LimitMail { get; set; }

        /// <summary>
        /// Emails sent limit for this plan (formatted style).
        /// </summary>
        [JsonProperty("limit_mail_formatted")]
        public string LimitMailFormatted { get; set; }

        /// <summary>
        /// Subscriber limit for this plan.
        /// </summary>
        [JsonProperty("limit_sub")]
        public int LimitSub { get; set; }

        /// <summary>
        /// Subscriber limit for this plan (formatted style).
        /// </summary>
        [JsonProperty("limit_sub_formatted")]
        public string LimitSubFormatted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("emailtestcredits")]
        public string EmailTestCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("emailtestcredits_formatted")]
        public string EmailTestCreditsFormatted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smscredits")]
        public string SmsCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smscredits_formatted")]
        public string SmsCreditsFormatted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("erja")]
        public string Erja { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("term_formatted")]
        public string TermFormatted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("term_formatted_per")]
        public string TermFormattedPer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("term_formatted_ly")]
        public string TermFormattedLy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("term_formatted_short")]
        public string TermFormattedShort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("price_permonth_formatted")]
        public string PricePerMonthFormattedShort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("price_permonth_formatted_smart")]
        public string PricePerMonthFormattedSmart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("price2show")]
        public string Price2Show { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("price2show_formatted")]
        public string Price2ShowFormatted { get; set; }

        /// <summary>
        /// Optional. If Account is provided, it will contain the price to switch to this plan.
        /// </summary>
        [JsonProperty("prorated")]
        public string Prorated { get; set; }
    }

    public class AccountPlansResponse : Result
    {
        public Dictionary<int, Plan> Plans { get; set; }
    }
}