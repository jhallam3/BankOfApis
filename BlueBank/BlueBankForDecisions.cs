using System;
namespace BlueBank
{
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



    }
}
