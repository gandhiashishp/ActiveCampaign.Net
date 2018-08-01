namespace ActiveCampaign.Net.Models.Campaign
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines the response received as a part of creating a campaign.
    /// </summary>
    public class CampaignCreateResponse : Result
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating the Id of the message just added.
        /// Example: 2
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion
    }
}
