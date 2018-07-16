using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ActiveCampaign.Net.Models.Contact
{
    public class BasicContactInfo
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("first_name")]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("last_name")]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }

        [Newtonsoft.Json.JsonProperty("orgname")]
        public string OrganizationName { get; set; }

        [Newtonsoft.Json.JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [Newtonsoft.Json.JsonProperty("ip4")]
        public string IPAddress { get; set; }

        public List<Field> Fields { get; set; }

        [Newtonsoft.Json.JsonProperty("form")]
        public int FormId { get; set; }
    }
}