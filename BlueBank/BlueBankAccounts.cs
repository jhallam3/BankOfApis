using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BlueBank.DataTypes.Account;
using BlueBank.DataTypes.Customer;
using BlueBank.DataTypes.Payment;
using BlueBank.DataTypes.Transactions;
using BlueBank.DataTypes.WebHooks;
using Newtonsoft.Json;

namespace BlueBank
{
    public class BlueBankAccounts
    {
        public async Task<string> GetAccountsByAccountIdAsync(string Ocp, string Auth, string AccountID)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
            client.DefaultRequestHeaders.Add("Authorization", Auth);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

            var uri = "https://bluebank.azure-api.net/api/v0.7/accounts/"+AccountID;

            var response = await client.GetAsync(uri);
            return response.Content.ToString();
        }

        public async Task<Customer> GetCustomersAsync(string Ocp, string Auth)
        {
            try
            {


                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // Request headers
                //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/api/v0.7/customers";

                var response = await client.GetStringAsync(uri);
                
                var result = JsonConvert.DeserializeObject<Customer>(response);
                return result;
            }
            catch (Exception ex2)
            {
                throw;
            }
        }

        public async Task<Customer> GetCustomerByIdAsync(string Ocp, string Auth, string Id)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
            client.DefaultRequestHeaders.Add("Authorization", Auth);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

            var uri = "https://bluebank.azure-api.net/api/v0.7/customers/" + Id;

            var response = await client.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<Customer>(response);
            return result;
        }

        public async Task<Account> GetCustomersAccounts(string Ocp, string Auth, string CustomerId)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // Request headers
                //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/api/v0.7/customers/" + CustomerId + "/accounts";

                var response = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<Account>(response);
                return result;
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<Transactions> GetTransactions(string Ocp, string Auth, string AccountId)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // Request headers
                //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/api/v0.7/accounts/" + AccountId + "/transactions";

                var response = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<Transactions>(response);
                return result;
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<PaymentResult[]> GetPaymentsForAllCustomers(string Ocp, string Auth)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // Request headers
                //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/v0.71/api/Payments";

                var response = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<List<PaymentResult>>(response);
                return result.ToArray();
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<PaymentResult> GetPaymentByIdForAllCustomers(string Ocp, string Auth, string Paymentid)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // Request headers
                //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/v0.71/api/Payments/"+ Paymentid;

                var response = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<PaymentResult>(response);
                return result;
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<HttpResponseMessage> PaymentCreate(string Ocp, string Auth, BlueBank.DataTypes.Payment.Payment Payment)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // Request headers
                //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "");
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/v0.71/api/Payments" ;
                

                var stringContent = new StringContent(JsonConvert.SerializeObject(Payment), Encoding.UTF8, "application/json");
                var response2 = await client.PostAsync(uri, stringContent);

                
                return response2;
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<ClassWebHookFilter[]> GetWebHookFilters_GetAll(string Ocp, string Auth)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

              
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/v0.7/api/WebHookFilters";


                var response = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<List<ClassWebHookFilter>>(response);


                return result.ToArray(); 
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<WebHookRegister[]> GetWebHookRegistrations_GetAllForCustomers(string Ocp, string Auth)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);


                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/v0.7/api/WebHookRegistrations";


                var response = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<List<WebHookRegister>>(response);


                return result.ToArray();
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<WebHookRegister> GetWebHookRegistrations_GetByWebhookId(string Ocp, string Auth, string Webhookid)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);


                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/v0.7/api/WebHookRegistrations/"+Webhookid;


                var response = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<WebHookRegister>(response);


                return result;
            }
            catch (Exception ex2)
            {

                throw;
            }

        }

        public async Task<HttpResponseMessage> PostWebHookRegistrations_Create(string Ocp, string Auth, WebHookRegister Webhook)
        {

            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                
                client.DefaultRequestHeaders.Add("Authorization", Auth);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp);

                var uri = "https://bluebank.azure-api.net/v0.7/api/WebHookRegistrations";


                var stringContent = new StringContent(JsonConvert.SerializeObject(Webhook), Encoding.UTF8, "application/json");
                var response2 = await client.PostAsync(uri, stringContent);


                return response2;
            }
            catch (Exception ex2)
            {

                throw;
            }

        }




    }









}
