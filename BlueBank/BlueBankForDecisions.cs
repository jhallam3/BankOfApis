using DecisionsFramework.Design.Flow;
using System;
namespace BlueBank
{
    [AutoRegisterMethodsOnClass(true, "Open Banking", "Bank Of Apis / Blue Bank", RegisterForAgents = true)]
    public class BlueBankForDecisions
    {
        public String GetAccountByAccountIdAsync(string ocp, string auth, string accountid)
        {
            try
            {
                var f = new BlueBankAccounts().GetAccountsByAccountIdAsync(ocp, auth, accountid).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTypes.Customer.Customer GetCustomersAsync (string ocp, string auth)
        {
            try
            {
                var f = new BlueBankAccounts().GetCustomersAsync(ocp, auth).Result;

                return f;
            }

            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTypes.Account.Account GetCustomersAccounts(string ocp, string auth, string customerid)
        {
            try
            {
                var f = new BlueBankAccounts().GetCustomersAccounts(ocp, auth, customerid).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTypes.Payment.PaymentResult GetPaymentByIdForAllCustomers(string ocp, string auth, string paymentid)
        {
            try
            {
                var f = new BlueBankAccounts().GetPaymentByIdForAllCustomers(ocp, auth, paymentid).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTypes.Payment.PaymentResult[] GetPaymentsForAllCustomers(string ocp, string auth)
        {
            try
            {
                var f = new BlueBankAccounts().GetPaymentsForAllCustomers(ocp, auth).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTypes.Transactions.Transactions GetTransactionsByAccountId(string ocp, string auth, string accountid)
        {
            try
            {
                var f = new BlueBankAccounts().GetTransactions(ocp, auth, accountid).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTypes.WebHooks.ClassWebHookFilter[] GetWebHookFilters_GetAll(string ocp, string auth)
        {
            try
            {
                var f = new BlueBankAccounts().GetWebHookFilters_GetAll(ocp, auth).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTypes.WebHooks.WebHookRegister[] GetWebHookRegistrations_GetAllForCustomers(string ocp, string auth)
        {
            try
            {
                var f = new BlueBankAccounts().GetWebHookRegistrations_GetAllForCustomers(ocp, auth).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTypes.WebHooks.WebHookRegister GetWebHookRegistrations_GetByWebhookId(string ocp, string auth, string webhookid)
        {
            try
            {
                var f = new BlueBankAccounts().GetWebHookRegistrations_GetByWebhookId(ocp, auth, webhookid).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public System.Net.Http.HttpResponseMessage PaymentCreate(string ocp, string auth, DataTypes.Payment.Payment payment)
        {
            try
            {
                var f = new BlueBank.BlueBankAccounts().PaymentCreate(ocp, auth, payment).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public System.Net.Http.HttpResponseMessage PostWebHookRegistrations_Create(string ocp, string auth, DataTypes.WebHooks.WebHookRegister Webhook)
        {
            try
            {
                var f = new BlueBankAccounts().PostWebHookRegistrations_Create(ocp, auth, Webhook).Result;

                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
