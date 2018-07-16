using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using ActiveCampaign.Net.Models;

namespace ActiveCampaign.Net.Services
{
    #region usings

    

    #endregion

    public abstract class ActiveCampaignService
    {
        public string ApiUrl;
        public string ApiKey;
        public string ApiPassword;

        protected ActiveCampaignService(string apiKey, string apiUrl, string apiPassword = null)
        {
            if (string.IsNullOrEmpty(apiUrl))
                throw new ArgumentException(Resources.ActiveCampaign.Invalid_API_Url, "apiUrl");
            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentException(Resources.ActiveCampaign.Invalid_API_key, "apiKey");

            ApiKey = apiKey;
            ApiUrl = CreateBaseUrl(apiUrl) + "&api_key=" + apiKey;
            ApiPassword = apiPassword;
        }

        private string CreateBaseUrl(string apiUrl)
        {
            string cleanedUrl = Regex.IsMatch(apiUrl, "/$") ? apiUrl.Substring(0, apiUrl.Length - 1) : apiUrl;

            if (Regex.IsMatch(apiUrl, "https://www.activecampaign.com"))
                return cleanedUrl + "/api.php?api_output=json";

            return cleanedUrl + "/admin/api.php?api_output=json";
        }

        /// <summary>
        /// Send Request method. 
        /// </summary>
        /// <param name="method">Active Campaign method name</param>
        /// <param name="getParameters">Optional. Dictionary with GET parameters</param>
        /// <param name="postParameters">Optional. Dictionary with POST parameters</param>
        /// <returns>JSON response as string from Active Campaign API</returns>
        public string SendRequest(string method, Dictionary<string, string> getParameters = null, Dictionary<string, string> postParameters = null)
        {
            if (string.IsNullOrEmpty(method))
                throw new ArgumentException("A valid ActiveCampaign API method was not specified", "method");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(ApiUrl);
            urlBuilder.Append("&api_action=" + method);


            if (getParameters != null)
            {
                foreach (var parameter in getParameters)
                {
                    urlBuilder.Append(string.Format("&{0}={1}", HttpUtility.UrlEncode(parameter.Key), HttpUtility.UrlEncode(parameter.Value)));
                }
            }

            var request = (HttpWebRequest)WebRequest.Create(urlBuilder.ToString());

            if (postParameters != null)
            {
                var requestData = new StringBuilder();

                foreach (var postParameter in postParameters)
                {
                    requestData.Append(
                        string.Format("&{0}={1}", HttpUtility.UrlEncode(postParameter.Key), HttpUtility.UrlEncode(postParameter.Value)));
                }

                var postString = requestData.ToString().Substring(1);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postString.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(Encoding.UTF8.GetBytes(postString), 0, postString.Length);
                }
            }

            string jsonResponse;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseStream = response.GetResponseStream();

                // Pipes the stream to a higher level stream reader with the required encoding format. 
                using (var readStream = new StreamReader(responseStream, Encoding.UTF8))
                {
                    jsonResponse = readStream.ReadToEnd();
                }
            }

            return jsonResponse;
        }

        /// <summary>
        /// Check if response is successfull
        /// </summary>
        /// <param name="response">Result type</param>
        /// <returns>bool</returns>
        public bool IsRequestSuccessfull(Result response)
        {
            if (response.ResultCode == 1)
            {
                return true;
            }

            return false;

        }
    }
}