using System;
using System.Collections.Generic;
using ActiveCampaign.Net.Models.Contact;

namespace ActiveCampaign.Net.Models
{
    public class ExtendedContactInfo : BasicContactInfo
    {

        public string Name { get; set; }

        public DateTime? SubscribedDateTime { get; set; }

        public DateTime? UnsubscribedDateTime { get; set; }

        public int? SentCount { get; set; }

        public int? Status { get; set; }

        public int? Responder { get; set; }

        public int? Sync { get; set; }

        public int? BouncedHard { get; set; }

        public int? BouncedSoft { get; set; }

        public DateTime? BouncedDate { get; set; }

        public int? Rating { get; set; }

        public bool? HasGravatar { get; set; }

        public bool? IsDeleted { get; set; }

        public List<BasicContactList> Lists { get; set; }

    }
}