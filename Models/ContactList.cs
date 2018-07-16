using System;
using ActiveCampaign.Net.Models.Contact;

namespace ActiveCampaign.Net.Models
{
    public class ContactList : BasicContactList
    {
        public DateTime Cdate { get; set; }

        public bool IsPrivate { get; set; }

        public int UserId { get; set; }

        public int SubscriberCount { get; set; }

    }
}