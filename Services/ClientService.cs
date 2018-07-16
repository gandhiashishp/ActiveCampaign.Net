using System;
using ActiveCampaign.Net.Models.User;
using Newtonsoft.Json;

namespace ActiveCampaign.Net.Services
{
    public class ClientService : ActiveCampaignService
    {
        public ClientService(string apiKey = null, string apiUrl = null, string apiPassword = null) : base(apiKey, apiUrl, apiPassword) { }

        /// <summary>
        /// Retrieve info about client
        /// </summary>
        /// <returns></returns>
        public UserInfoResponse ClientMe()
        {
            try
            {
                var jsonResponse = SendRequest("client_me", null, null);

                var response = JsonConvert.DeserializeObject<UserInfoResponse>(jsonResponse);

                return response;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
        }
    }
}