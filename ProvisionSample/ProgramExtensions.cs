using ApiHost.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.PowerBI.Api.V1;
using Microsoft.Rest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace ProvisionSample
{
    partial class Program
    {
        static string clientId = "8ff92caf-3141-47c5-8ada-1f00769d2bcb";
        static Uri redirectUri = new Uri("urn:ietf:wg:oauth:2.0:oob");
        static string azureToken = null;

        private static HttpClient CreateHttpClient()
        {
            return new HttpClient();
        }
        private static async Task SetAuthorizationHeaderIfNeeded(HttpRequestMessage request)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await GetAzureAccessTokenAsync());
        }

        /// <summary>
        /// Creates a new instance of the PowerBIClient with the specified token
        /// </summary>
        /// <returns></returns>
        static async Task<PowerBIClient> CreateClient()
        {
            if (accessKeys == null)
            {
                var enteredKey = userInput.EnterOptionalParam("Access Key", "Auto select");
                if (!string.IsNullOrWhiteSpace(enteredKey))
                {
                    accessKey = enteredKey;
                    accessKeys = new WorkspaceCollectionKeys()
                    {
                        Key1 = accessKey
                    };
                }
            }

            if (accessKeys == null)
            {
                // get the current collection's keys
                accessKeys = await ListWorkspaceCollectionKeys(subscriptionId, resourceGroup, workspaceCollectionName);
            }

            // Create a token credentials with "AppKey" type
            var credentials = new TokenCredentials(accessKeys.Key1, "AppKey");

            // Instantiate your Power BI client passing in the required credentials
            var client = new PowerBIClient(credentials);

            // Override the api endpoint base URL.  Default value is https://api.powerbi.com
            client.BaseUri = new Uri(apiEndpointUri);

            return client;
        }

        static async Task<IEnumerable<string>> GetTenantIdsAsync(string commonToken)
        {
            using (var httpClient = CreateHttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + commonToken);
                var response = await httpClient.GetStringAsync("https://management.chinacloudapi.cn/tenants?api-version=2016-01-29");
                var tenantsJson = JsonConvert.DeserializeObject<JObject>(response);
                var tenants = tenantsJson["value"] as JArray;

                return tenants.Select(t => t["tenantId"].Value<string>());
            }
        }

        /// <summary>
        /// Gets an Azure access token that can be used to call into the Azure ARM apis.
        /// </summary>
        /// <returns>A user token to access Azure ARM</returns>
        static async Task<string> GetAzureAccessTokenAsync()
        {
            if (!string.IsNullOrWhiteSpace(azureToken))
            {
                return azureToken;
            }
            /*
            var tokenresp = GetAzureAccessToken();

            if(tokenresp != null)
            {
                return (azureToken = tokenresp);
            }
            */
            var commonToken = GetCommonAzureAccessToken();
            var tenantId = (await GetTenantIdsAsync(commonToken.AccessToken)).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(tenantId))
            {
                throw new InvalidOperationException("Unable to get tenant id for user accout");
            }

            var authority = string.Format("https://login.chinacloudapi.cn/{0}/oauth2/authorize", tenantId);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenByRefreshTokenAsync(commonToken.RefreshToken, clientId, armResource);

            return (azureToken = result.AccessToken);

        }

        static string GetAzureAccessToken()
        {
            var loginEndpoint = System.Configuration.ConfigurationManager.AppSettings["azureLoginEndpoint"];
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(loginEndpoint);
                var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("resource", "https://management.core.chinacloudapi.cn/"),
                    new KeyValuePair<string, string>("client_id", "8ff92caf-3141-47c5-8ada-1f00769d2bcb"),
                    new KeyValuePair<string, string>("client_secret", "intelab-2017")
                };

                var body = new FormUrlEncodedContent(pairs);
                HttpResponseMessage response = httpClient.PostAsync("/ce5605b8-abf1-4900-bd33-19822c98f924/oauth2/token?api-version=1.0", body).Result;
                if (response.IsSuccessStatusCode)
                {

                    string contentstr = response.Content.ReadAsStringAsync().Result;
                    foreach (KeyValuePair<string, JToken> prop in JObject.Parse(contentstr))
                    {
                        Console.WriteLine(string.Format("Name: {0}, value: {1}", prop.Key, prop.Value.ToString()));
                    }
                    string tokenstr = JObject.Parse(contentstr).GetValue("access_token").ToString();
                    return tokenstr;
                }
                else
                {
                    throw new InvalidOperationException(string.Format("Failed to object azure access token. {0}", response.ReasonPhrase));
                }
            }
        }

        /// <summary>
        /// Gets a user common access token to access ARM apis
        /// </summary>
        /// <returns></returns>
        static AuthenticationResult GetCommonAzureAccessToken()
        {
            var authContext = new AuthenticationContext("https://login.chinacloudapi.cn/common/oauth2/authorize");
            var result = authContext.AcquireToken(
                resource: armResource,
                clientId: clientId,
                redirectUri: redirectUri,
                promptBehavior: PromptBehavior.Auto);

            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            return result;
        }
    }
}

