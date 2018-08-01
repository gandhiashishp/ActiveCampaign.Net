namespace ActiveCampaign.Net.Models.Campaign
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public enum CampaignType
    {
        Single,
        Recurring,
        Split,
        Responder,
        Reminder,
        Special,
        Activerss,
        Text
    }

    public enum CampaignStatus
    {
        Draft = 0,
        Scheduled = 1
    }

    public enum LinkTrackingType
    {
        None,
        All,
        Mime,
        Html,
        Text
    }

    /// <summary>
    /// Class containing the parameters needed to be used in order
    /// to create a campaign.
    /// </summary>
    public class CampaignCreate
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating the name of this campaign to use in Google Analytics. Example: 'Friday Newsletter: Analytics'
        /// </summary>
        public string AnalyticsCampaignName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating expected API output format. xml, json, or serialize (default is json)
        /// </summary>
        public string ApiOutput { get; set; }

        /// <summary>
        /// Gets or sets a value indicating custom unsubscribe link addons (DOWNLOADED USERS ONLY).
        /// Example: '<div><a href="%UNSUBSCRIBELINK%">Click here</a> to unsubscribe from future mailings.</div>'.
        /// </summary>
        public string HtmlUnsubscribeCustomData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to append unsubscribe link to the bottom of HTML body. Example: 1 = yes, 0 = no.
        /// </summary>
        public bool IsToAppendUnsuscribeLinkToHtmlBody { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to append unsubscribe link to the bottom of TEXT body. Example: 1 = yes, 0 = no.
        /// </summary>
        public bool IsToAppendUnsuscribeLinkToTextBody { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to use the lists' Google Analytics settings. Example: 1 = yes, 0 = no.
        /// </summary>
        public bool IsToTrackLinkAnalytics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to track reads. Examples: 0 = no, 1 = yes.
        /// </summary>
        public bool IsToTrackReads { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to track replies. Example: 1 = yes, 0 = no.
        /// </summary>
        public bool IsToTrackReplies { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to use lists' Facebook settings. Example: 1 = yes, 0 = no.
        /// </summary>
        public bool IsToUseListFacebookSettings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to use lists' Twitter settings. Example: 1 = yes, 0 = no.
        /// </summary>
        public bool IsToUseListTweetSettings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the internal campaign name. Example: 'Friday Newsletter'
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the date when the campaign should be sent out (not used for campaign types 'responder', 'reminder', 'special').
        /// Example: '2010-11-05 08:40:00'
        /// </summary>
        public DateTime ScheduleDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating List segment ID (0 for no segment)
        /// </summary>
        [DefaultValue(0)]
        public int SegmentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating message id to be used for creating a campaign.
        /// </summary>
        public long MessageId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the list ids to be used for extracting the contacts to deliver the campaign.
        /// </summary>
        public List<int> ListIds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the status of the campaign. Example: 0 = draft, 1 = scheduled
        /// </summary>
        public CampaignStatus Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating custom unsubscribe link addons (DOWNLOADED USERS ONLY).
        /// Example: 'Click here to unsubscribe from future mailings: %UNSUBSCRIBELINK%'.
        /// </summary>
        public string TextUnsubscribeCustomData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to track links, and what type of links to track. Examples: 'all', 'mime', 'html', 'text', 'none'.
        /// Setting this value to 'all' will let the system know to fetch, parse, and track all emails it finds in both TEXT and HTML body. 
        /// If mime/html/text is provided, then variable 'links' also must exist, with a list of URLs to track. Choosing 'html' or 'text' 
        /// will track only the links in that message body.
        /// </summary>
        public LinkTrackingType TrackLinks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating Campaign type. 
        /// Example: 'single', 'recurring', 'split', 'responder', 'reminder', 'special', 'activerss', 'text'
        /// </summary>
        public CampaignType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the campaign should be made publicly visible or not.
        /// - if the campaign should be visible on the public side. Example: 1 = visible, 0 = not visible.
        /// </summary>
        public bool Visible { get; set; }

        #endregion
    }
}
