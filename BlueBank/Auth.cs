using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace BlueBank
{
    public class Auth
    {
        public async Task<string> Auth2Async()
        {
            try
            {
                string resourceUrl = "https://login.microsoftonline.com/bluebankb2c.onmicrosoft.com/oauth2/v2.0/authorize?p=B2C_1_BlueBankSUSI";
                string clientId = "0f7ef810-2f9c-424c-942a-48c6ea361d9a";
                HttpClient client = new HttpClient();
                string tokenEndpoint = "https://login.microsoftonline.com/{tenantId}/oauth2/token";

                var body = "resource="+resourceUrl+"&client_id="+clientId+"&grant_type=password&username={userName}&password={password}";
                var stringContent = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");

                var result = await client.PostAsync(tokenEndpoint, stringContent).ContinueWith<string>((response) =>
                {
                    return response.Result.Content.ReadAsStringAsync().Result;
                });

                JObject jobject = JObject.Parse(result);

                var token = jobject["access_token"].Value<string>();
                return null;

            }
            catch (Exception ex2)
            {

                throw;
            }       }
    }
}
