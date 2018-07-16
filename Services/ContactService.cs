using System;
using System.Collections.Generic;
using System.Linq;
using ActiveCampaign.Net.Models.Contact;
using Newtonsoft.Json;

namespace ActiveCampaign.Net.Services
{
    public class ContactService : ActiveCampaignService
    {
        public ContactService(string apiKey = null, string apiUrl = null, string apiPassword = null) : base(apiKey, apiUrl, apiPassword) { }

        /// <summary>
        /// View only one contact's details by searching for their email address.
        /// </summary>
        /// <param name="email">
        /// Email address of the contact you are looking up. Example: 'test@example.com'
        /// </param>
        /// <returns></returns>
        public BasicContactInfo GetContactInfo(string email)
        {
            var getData = new Dictionary<string, string>
            {
                {"email", email},
            };
            var jsonResponse = SendRequest("contact_view_email", getData, null);

            var response = JsonConvert.DeserializeObject<BasicContactInfo>(jsonResponse);
            return response;
        }

        /// <summary>
        /// Add or edit a contact based on their email address. Instead of calling contact_view to check if the contact exists, 
        /// and then calling contact_add or contact_edit, you can make just one call and include only the information you want added or updated.
        /// </summary>
        /// <param name="basicContactInfo"></param>
        /// <param name="contactLists"></param>
        /// <returns></returns>
        public ContactSyncResponse SyncContact(BasicContactInfo basicContactInfo, IEnumerable<BasicContactList> contactLists)
        {
            var postData = new Dictionary<string, string>
            {
                {"email", basicContactInfo.Email},
                {"first_name", basicContactInfo.FirstName ?? ""},
                {"last_name", basicContactInfo.LastName ?? ""},
                {"phone", basicContactInfo.Phone ?? ""},
                {"orgname", basicContactInfo.OrganizationName ?? ""},
                {"form", basicContactInfo.FormId.ToString() ?? ""},
            };

            if (basicContactInfo.Tags != null && basicContactInfo.Tags.Any())
            {
                postData.Add("tags", string.Join(",", basicContactInfo.Tags));
            }

            foreach (var contactList in contactLists)
            {
                postData.Add(string.Format("p[{0}]", contactList.Id), contactList.Id.ToString());
                postData.Add(string.Format("status[{0}]", contactList.Id), contactList.Status.ToString("D"));
                postData.Add(string.Format("noresponders[{0}]", contactList.Id),
                    Convert.ToInt32(contactList.Noresponders).ToString());
                postData.Add(string.Format("sdate[{0}]", contactList.Id), contactList.SubscribeDate);
                postData.Add(string.Format("instantresponders[{0}]", contactList.Id),
                    Convert.ToInt32(contactList.InstantResponders).ToString());
                postData.Add(string.Format("lastmessage[{0}]", contactList.Id),
                    Convert.ToInt32(contactList.LastMessage).ToString());
            }

            if (basicContactInfo.Fields != null && basicContactInfo.Fields.Any())
            {
                foreach (var field in basicContactInfo.Fields)
                {
                    postData.Add(string.Format("field[{0},0]", field.Id != null ? field.Id.ToString() : field.Name),
                        field.Value);
                }
            }

            var jsonResponse = SendRequest("contact_sync", null, postData);

            var response = JsonConvert.DeserializeObject<ContactSyncResponse>(jsonResponse);

            return response;
        }
    }
}