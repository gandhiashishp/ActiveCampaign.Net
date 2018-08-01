namespace ActiveCampaign.Net.Models.Campaign
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines the response received as a part of adding the message.
    /// </summary>
    public class MessageAddResponse : Result
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating the Id of the message just added.
        /// Example: 2
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the subject of the message just added.
        /// Example: Email Subject
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        #endregion
    }
}
