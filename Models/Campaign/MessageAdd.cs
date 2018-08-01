namespace ActiveCampaign.Net.Models.Campaign
{
    /// <summary>
    /// Class containing the parameters needed to be used in order
    /// to add a message to active campaign.
    /// </summary>
    public class MessageAdd
    {
        #region Properties

        /// <summary>
        /// Gets or sets expected API output format. xml, json, or serialize (default is json)
        /// </summary>
        public string ApiOutput { get; set; }

        /// <summary>
        /// Gets or sets the Charset
        /// Character set used. Example: 'utf-8'
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// Gets or sets the Encoding
        /// Encoding used. Example: 'quoted-printable'
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets the Format
        /// Examples: html, text, mime (both html and text)
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the FromEmail
        /// The "From" email address. Example: 'test@example.com'
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// Gets or sets the FromName
        /// The "From" name. Example: 'From Name'
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// Gets or sets the content of your html email. Example: '<strong>html</strong> content of your email'
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets the HTML version.
        /// Examples: editor, external, upload. 
        ///  -If editor, it uses 'html' parameter. 
        /// - If external, uses 'htmlfetch' and 'htmlfetchwhen' parameters. 
        /// - If upload, uses 'message_upload_html'.
        /// </summary>
        public string HtmlConstructor { get; set; }

        /// <summary>
        /// Gets or sets the HTML version.
        /// URL where to fetch the body from. Example: 'http://somedomain.com/somepage.html'
        /// </summary>
        public string HtmlFetch { get; set; }

        /// <summary>
        /// Gets or sets the HTML version
        /// Examples: (fetch at) 'send' and (fetch) 'pers'(onalized)
        /// </summary>
        public string HtmlFetchWhen { get; set; }

        /// <summary>
        /// Gets or sets the Priority
        /// Examples: 1 = high, 3 = medium/default, 5 = low
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the "Reply To" email address. Example: 'reply2@example.com'
        /// </summary>
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets subject of the email message.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets Text version. Content of your text only email. Example: '_text only_ content of your email'
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets text version. Examples: editor, external, upload. 
        /// - If editor, it uses 'text' parameter. 
        /// - If external, uses 'textfetch' and 'textfetchwhen' parameters. 
        /// - If upload, uses 'message_upload_text'.
        /// </summary>
        public string TextConstructor { get; set; }

        /// <summary>
        /// Gets or sets the TextFetch
        /// Text version. URL where to fetch the body from. Example: 'http://somedomain.com/somepage.txt'
        /// </summary>
        public string TextFetch { get; set; }

        /// <summary>
        /// Gets or sets text version. When to fetch. Examples: (fetch at) 'send' and (fetch) 'pers'(onalized)
        /// </summary>
        public string TextFetchWhen { get; set; }

        /// <summary>
        /// Gets or sets the id of the list to which the message will be attached.
        /// </summary>
        public int ListId { get; set; }

        #endregion
    }
}
