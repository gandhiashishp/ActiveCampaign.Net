using ActiveCampaign.Net.Enums;

namespace ActiveCampaign.Net.Models.Contact
{
    public class BasicContactList
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SubscriptionStatus Status { get; set; }

        public bool Noresponders { get; set; }

        public string SubscribeDate { get; set; }

        public bool InstantResponders { get; set; }

        public bool LastMessage { get; set; }
    }
}