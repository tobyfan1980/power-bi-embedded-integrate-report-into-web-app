using ApiHost.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.PowerBI.Api.V1;
using Microsoft.PowerBI.Api.V1.Models;
using Microsoft.PowerBI.Security;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProvisionWinFormSample
{
    public partial class Form1 : Form
    {
        const string version = "?api-version=2016-01-29";
        const string armResource = "https://management.core.windows.net/";
        private string clientId = "ea0616ba-638b-4df5-95b9-636659ae5121";
        private Uri redirectUri = new Uri("urn:ietf:wg:oauth:2.0:oob");

        private string apiEndpointUri = ConfigurationManager.AppSettings["powerBiApiEndpoint"];
        private string azureEndpointUri = ConfigurationManager.AppSettings["azureApiEndpoint"];
        private string subscriptionId = ConfigurationManager.AppSettings["subscriptionId"];
        private string resourceGroup = ConfigurationManager.AppSettings["resourceGroup"];
        private string workspaceCollectionName = ConfigurationManager.AppSettings["workspaceCollectionName"];
        private string username = ConfigurationManager.AppSettings["username"];
        private string password = ConfigurationManager.AppSettings["password"];
        private string accessKey = ConfigurationManager.AppSettings["accessKey"];
        private string datasetId = ConfigurationManager.AppSettings["datasetId"];
        private string workspaceId = ConfigurationManager.AppSettings["workspaceId"];
        private string azureToken = null;

        private WorkspaceCollectionKeys accessKeys = null;

        public Form1()
        {
            if (!string.IsNullOrWhiteSpace(accessKey))
            {
                accessKeys = new WorkspaceCollectionKeys
                {
                    Key1 = accessKey
                };
            }

            InitializeComponent();
        }

        /// <summary>
        /// Gets the workspace collection access keys for the specified collection
        /// </summary>
        /// <param name="subscriptionId">The azure subscription id</param>
        /// <param name="resourceGroup">The azure resource group</param>
        /// <param name="workspaceCollectionName">The Power BI workspace collection name</param>
        /// <returns></returns>
        private async Task<WorkspaceCollectionKeys> ListWorkspaceCollectionKeys(string subscriptionId, string resourceGroup, string workspaceCollectionName)
        {
            var url = string.Format("{0}/subscriptions/{1}/resourceGroups/{2}/providers/Microsoft.PowerBI/workspaceCollections/{3}/listkeys{4}", azureEndpointUri, subscriptionId, resourceGroup, workspaceCollectionName, version);

            HttpClient client = new HttpClient();

            using (client)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                // Set authorization header from you acquired Azure AD token
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await GetAzureAccessTokenAsync());
                request.Content = new StringContent(string.Empty);
                var response = await client.SendAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var responseText = await response.Content.ReadAsStringAsync();
                    var message = string.Format("Status: {0}, Reason: {1}, Message: {2}", response.StatusCode, response.ReasonPhrase, responseText);
                    throw new Exception(message);
                }

                var json = await response.Content.ReadAsStringAsync();
                return SafeJsonConvert.DeserializeObject<WorkspaceCollectionKeys>(json);
            }
        }

        /// <summary>
        /// Gets the workspace collection metadata for the specified collection
        /// </summary>
        /// <param name="subscriptionId">The azure subscription id</param>
        /// <param name="resourceGroup">The azure resource group</param>
        /// <param name="workspaceCollectionName">The Power BI workspace collection name</param>
        /// <returns></returns>
        private async Task<string> GetWorkspaceCollections(string subscriptionId, string resourceGroup)
        {
            var url = string.Format("{0}/subscriptions/{1}/resourceGroups/{2}/providers/Microsoft.PowerBI/workspaceCollections{3}", azureEndpointUri, subscriptionId, resourceGroup, version);
            HttpClient client = new HttpClient();

            using (client)
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                // Set authorization header from you acquired Azure AD token
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await GetAzureAccessTokenAsync());
                var response = await client.SendAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(message); //for debugging
                    return null;
                }

                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
        }

        /// <summary>
        /// Gets a list of Power BI Embedded workspaces within the specified collection
        /// </summary>
        /// <param name="workspaceCollectionName">The Power BI workspace collection name</param>
        /// <returns></returns>
        private async Task<IEnumerable<Workspace>> GetWorkspaces(string workspaceCollectionName)
        {
            using (var client = await CreateClient())
            {
                try
                {
                    var response = await client.Workspaces.GetWorkspacesByCollectionNameAsync(workspaceCollectionName);
                    return response.Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex); //for debugging
                    return null;
                }
            }
        }

        /// <summary>
        /// Lists the datasets that are published to a given workspace.
        /// </summary>
        /// <param name="workspaceCollectionName">The Power BI workspace collection name</param>
        /// <param name="workspaceId">The target Power BI workspace id</param>
        /// <returns></returns>
        private async Task<IList<Dataset>> GetDatasets(string workspaceCollectionName, string workspaceId)
        {

            using (var client = await CreateClient())
            {
                try
                {
                    var response = await client.Datasets.GetDatasetsAsync(workspaceCollectionName, workspaceId);
                    return response.Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex); //for debugging
                    return null;
                }
            }
        }

        private async Task<IList<Report>> GetReports(string workspaceCollectionName, string workspaceId)
        {
            using (var client = await CreateClient())
            {
                try
                {
                    var response = await client.Reports.GetReportsAsync(workspaceCollectionName, workspaceId);
                    return response.Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex); //for debugging
                    return null;
                }
            }
        }

        /// <summary>
        /// Creates a new instance of the PowerBIClient with the specified token
        /// </summary>
        /// <returns></returns>
        async Task<PowerBIClient> CreateClient()
        {
            if (accessKeys == null)
            {
                accessKeys = await ListWorkspaceCollectionKeys(this.txtSubscriptionId.Text, this.txtResourceGroup.Text, CurrWorkspaceCollectionName);
            }

            // Create a token credentials with "AppKey" type
            var credentials = new TokenCredentials(accessKeys.Key1, "AppKey");

            // Instantiate your Power BI client passing in the required credentials
            var client = new PowerBIClient(credentials);

            // Override the api endpoint base URL.  Default value is https://api.powerbi.com
            client.BaseUri = new Uri(apiEndpointUri);

            return client;
        }

        private async Task<IEnumerable<string>> GetTenantIdsAsync(string commonToken)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + commonToken);
                var response = await httpClient.GetStringAsync("https://management.azure.com/tenants?api-version=2016-01-29");
                var tenantsJson = JsonConvert.DeserializeObject<JObject>(response);
                var tenants = tenantsJson["value"] as JArray;

                return tenants.Select(t => t["tenantId"].Value<string>());
            }
        }

        /// <summary>
        /// Gets an Azure access token that can be used to call into the Azure ARM apis.
        /// </summary>
        /// <returns>A user token to access Azure ARM</returns>
        private async Task<string> GetAzureAccessTokenAsync()
        {
            if (!string.IsNullOrWhiteSpace(azureToken))
            {
                return azureToken;
            }

            var commonToken = GetCommonAzureAccessToken();
            var tenantId = (await GetTenantIdsAsync(commonToken.AccessToken)).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(tenantId))
            {
                throw new InvalidOperationException("Unable to get tenant id for user accout");
            }

            var authority = string.Format("https://login.windows.net/{0}/oauth2/authorize", tenantId);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenByRefreshTokenAsync(commonToken.RefreshToken, clientId, armResource);

            return (azureToken = result.AccessToken);

        }

        /// <summary>
        /// Gets a user common access token to access ARM apis
        /// </summary>
        /// <returns></returns>
        private AuthenticationResult GetCommonAzureAccessToken()
        {
            var authContext = new AuthenticationContext("https://login.windows.net/common/oauth2/authorize");
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

        private async void btnLoadWC_Click(object sender, EventArgs e)
        { 
            this.comboWorkspaceCollections.Enabled = false;

            var responseContent = await GetWorkspaceCollections(this.txtSubscriptionId.Text, this.txtResourceGroup.Text);
            if (string.IsNullOrEmpty(responseContent))
            {
                MessageBox.Show("No workspace collections found. Response is empty.");
                return;
            }

            PBIWorkspaceCollections workspaceCollections = JsonConvert.DeserializeObject<PBIWorkspaceCollections>(responseContent);
            if (workspaceCollections == null || workspaceCollections.value == null || workspaceCollections.value.Count() == 0)
            {
                MessageBox.Show("No workspace collections found.");
                return;
            }

            this.comboWorkspaceCollections.DataSource = workspaceCollections.value;
            this.comboWorkspaceCollections.DisplayMember = "name";
            this.comboWorkspaceCollections.ValueMember = "name";

            this.comboWorkspaceCollections.Enabled = true;
        }

        private async void LoadWorkspaces(string workspaceName)
        {
            try
            {
                this.comboWorkspaces.Enabled = false;
                var workspaces = await GetWorkspaces(workspaceName);

                if (workspaces == null || workspaces.Count() == 0)
                {
                    this.comboWorkspaces.DataSource = null;
                    MessageBox.Show("no workspaces found in this workspace collection.");
                    return;
                }

                this.comboWorkspaces.DataSource = workspaces.ToList();
                this.comboWorkspaces.DisplayMember = "WorkspaceId";
                this.comboWorkspaces.ValueMember = "WorkspaceId";
                this.comboWorkspaces.Enabled = true;
            }
            catch(Exception ex)
            {
                this.comboWorkspaces.DataSource = null;
                Console.WriteLine(ex);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtSubscriptionId.Text = subscriptionId;
            this.txtResourceGroup.Text = resourceGroup;

            this.comboWorkspaceCollections.Enabled = false;
            this.comboWorkspaces.Enabled = false;
        }

        public class PBIWorkspaceCollections
        {
            public PBIWorkspaceCollection[] value { get; set; }
        }
        public class PBIWorkspaceCollection
        {
            public string id { get; set; }

            // the name of this property will change to 'displayName' when the API moves from Beta to V1 namespace
            public string name { get; set; }

            public string location { get; set; }

            public string type { get; set; }
        }

        private void comboWorkspaceCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrWorkspaceCollectionName))
            {
                LoadWorkspaces(CurrWorkspaceCollectionName);
            }
        }

        private async void comboWorkspaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            var datasets = await GetDatasets(CurrWorkspaceCollectionName, CurrWorkspace); //TODO: Exception thrown when CurrWorkspace is empty (no workspaces in collection)
            this.dataGridView1.DataSource = datasets;

            var reports = await GetReports(CurrWorkspaceCollectionName, CurrWorkspace);
            this.dataGridView2.DataSource = reports;
        }

        public string CurrWorkspaceCollectionName {
            get
            {
                var workspaceCollectionItem = this.comboWorkspaceCollections.SelectedItem as PBIWorkspaceCollection;
                if(workspaceCollectionItem == null)
                {
                    return "";
                }
                return workspaceCollectionItem.name;
            }
        }

        public string CurrWorkspace
        {
            get
            {
                var workspace = this.comboWorkspaces.SelectedItem as Workspace;
                if (workspace == null)
                {
                    return "";
                }
                return workspace.WorkspaceId;
            }
        }

        private async void btnEmbed_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a report to embed");
                return;
            }

            var reportRowCells = this.dataGridView2.SelectedRows[0].Cells;

            var reportId = reportRowCells["id"].Value.ToString();
            var embedUrl = reportRowCells["embedUrl"].Value.ToString();

            if (accessKeys == null)
            {
                accessKeys = await ListWorkspaceCollectionKeys(this.txtSubscriptionId.Text, this.txtResourceGroup.Text, CurrWorkspaceCollectionName);
            }

            var embedToken = PowerBIToken.CreateReportEmbedToken(CurrWorkspaceCollectionName, CurrWorkspace, reportId);
            var token = embedToken.Generate(this.accessKeys.Key1);

            var embedSampleUrlFormat = @"http://10.166.111.78:8080/code-demo/index.html?embedUrl={0}&embedId={1}&accessToken={2}";

            var embedSampleUrl = string.Format(embedSampleUrlFormat, HttpUtility.UrlEncode(embedUrl), reportId, token);

            Process.Start(embedSampleUrl);
        }
    }
}
