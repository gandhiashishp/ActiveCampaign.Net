using System;
using System.Collections.Generic;
using ActiveCampaign.Net.Models;
using ActiveCampaign.Net.Models.Account;
using Newtonsoft.Json;

namespace ActiveCampaign.Net.Services
{
    public class AccountService : ActiveCampaignService
    {
        public AccountService(string apiKey = null, string apiUrl = null, string apiPassword = null) : base(apiKey, apiUrl, apiPassword) { }

        /// <summary>
        /// Add a new account, just like you would on the Manage Accounts page of the reseller panel.
        /// </summary>
        /// <param name="model">AccountModel</param>
        /// <returns>AccountResponseModel</returns>
        public AccountAddResponse AccountAdd(AccountAdd model)
        {
            try
            {
                var postData = new Dictionary<string, string>()
                {
                    {"account", model.AccountName},
                    {"cname", model.Cname},
                    {"name", model.Name},
                    {"email", model.Email},
                    {"notification", model.Notification},
                    {"plan", model.PlanId.ToString()},
                    {"language", model.Language},
                    {"timezone", model.Timezone}
                };

                var jsonResponse = SendRequest("account_add", null, postData);

                var response = JsonConvert.DeserializeObject<AccountAddResponse>(jsonResponse);

                return response;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
        }

        /// <summary>
        /// Allows you to cancel an active and payed account.
        /// </summary>
        /// <param name="accountName">account name that you wish to cancel. Example: account.activehosted.com</param>
        /// <param name="reason">reason for cancelling the account</param>
        /// <returns>Result Object</returns>
        public Result AccountCancel(string accountName, string reason)
        {
            try
            {
                var data = new Dictionary<string, string>()
            {
                {"account", accountName},
                {"reason", reason},
            };

                var jsonResponse = SendRequest("account_cancel", data, null);
                var response = JsonConvert.DeserializeObject<Result>(jsonResponse);

                return response;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
        }

        /// <summary>
        /// View multiple accounts under your reseller profile including all information associated with each
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public AccountListResponse AccountList(string search = null)
        {
            try
            {
                var data = new Dictionary<string, string>()
                {
                    {"search", search},
                };

                var jsonResponse = SendRequest("account_list", data, null);
                var response = JsonConvert.DeserializeObject<AccountListResponse>(jsonResponse);

                return response;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
        }

        /// <summary>
        /// Allows you to retrieve a list of currently available plans for an account.
        /// </summary>
        /// <param name="accountName">account name that you wish to check the plans for. Leave empty to get default plans.</param>
        /// <returns>List of plans casted to List of object</returns>
        public Result AccountNameCheck(string accountName)
        {
            try
            {
                var data = new Dictionary<string, string>()
                {
                    { "account", accountName },
                };

                var jsonResponse = SendRequest("account_name_check", data, null);

                var response = JsonConvert.DeserializeObject<Result>(jsonResponse);

                return response;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
        }

        /// <summary>
        /// Allows you to retrieve a list of currently available plans for an account.
        /// </summary>
        /// <param name="accountName">full account name that you wish to check the plans for. Leave empty to get default plans.</param>
        /// <returns>List of plans casted to List of object</returns>
        public AccountPlansResponse AccountPlans(string accountName = null)
        {
            try
            {
                var data = new Dictionary<string, string>();

                if (accountName != null)
                {
                    data.Add("account", accountName);
                }

                var jsonResponse = SendRequest("account_plans", data, null);

                var response = JsonConvert.DeserializeObject<AccountPlansResponse>(jsonResponse);

                return response;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
        }

        /// <summary>
        /// Allows you to check the account status. Possible results are active, disabled, creating, cancelled.
        /// </summary>
        /// <param name="accountName">account name that you wish to check. ".activehosted.com" will be appended for you</param>
        /// <returns>AccountStatus model</returns>
        public AccountStatusResponse AccountStatus(string accountName)
        {
            try
            {
                var data = new Dictionary<string, string>()
                {
                    { "account", accountName },
                };

                var jsonResponse = SendRequest("account_status", data, null);

                var response = JsonConvert.DeserializeObject<AccountStatusResponse>(jsonResponse);

                return response;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
        }
    }
}
