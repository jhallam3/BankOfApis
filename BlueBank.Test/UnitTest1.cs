using BlueBank;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using BlueBank.DataTypes.WebHooks;
using System.Collections.Generic;

namespace BlueBank.Test
{
    [TestClass]
    public class UnitTest1
    {
        string ocp = "aae52a4a909d4d22ab1ee7e8e54cc00a";

        string accountid = "1a5b0078-738a-4e21-9389-156ccd362f44";

        string auth = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MjA1ODYzMzUsIm5iZiI6MTUyMDU4MjczNSwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6ImEyNjVhOWI5LWI0ZWUtNGExYy05ZmY0LWU5MDcyNGViYTFiOSIsImF1ZCI6IjQwOTU3YjljLTYzYmMtNGFiNC05ZWNiLTY3YjU0M2M4ZTRjYSIsIm5vbmNlIjoiZGVmYXVsdE5vbmNlIiwiaWF0IjoxNTIwNTgyNzM1LCJhdXRoX3RpbWUiOjE1MjA1ODI3MzUsIm9pZCI6ImEyNjVhOWI5LWI0ZWUtNGExYy05ZmY0LWU5MDcyNGViYTFiOSIsIm5hbWUiOiJKb24iLCJmYW1pbHlfbmFtZSI6IkhhbGxhbSIsImdpdmVuX25hbWUiOiJKb24iLCJlbWFpbHMiOlsiSm9uLkhhbGxhbUBNYW5hZ2VkLURlc2t0b3AuY29tIl0sInRmcCI6IkIyQ18xX0JsdWVCYW5rU1VTSSJ9.S3nvhRqFOtlGBd8js1swFFjHNZ2xxAcT7z0YTwCNHJ8r2K8WELmX0o7HL6-A4wVHy4kh2tX5Cu0-QC1ySsTKWbkT56I-51xF-BJMvgOQAoflvnH1b7wsYQPfHDyKg2MWeXeQWfWCQz2tqqSA_3RKKgqPGTx8RtJRCbxNnSDVHa4K0FHing7UlPOXuINCnTz3h76VFCOWETzuR-ASi6hHA1QCsES55i_GDaJ54aH4oMN5RrK78pr1xnU47yBNIbRoHwjavGMThH6u4RC3io2OUxBs5dS6ZbnaPDaIZfBkhIRKcxV_jNz7GcuHQ6yanBcwsGnX1tPdDMafDPjYb1HOaA";
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod1Async()
        {

            var f = new BlueBank.BlueBankAccounts();
            await f.GetCustomersAsync(ocp, auth);

        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodGetAccountsAsync()
        {

            var f = new BlueBank.BlueBankAccounts();
            await f.GetCustomersAccounts(ocp, auth, "a265a9b9-b4ee-4a1c-9ff4-e90724eba1b9");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodGeTransactionsAsync()
        {

            var f = new BlueBank.BlueBankAccounts();

            await f.GetTransactions(ocp, auth, accountid);
        }


        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodGetPaymentsForAllCustomersAsync()
        {

            var f = new BlueBank.BlueBankAccounts();

            await f.GetPaymentsForAllCustomers(ocp, auth);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodGetPaymentByIdAllCustomersAsync()
        {

            var f = new BlueBank.BlueBankAccounts();

            await f.GetPaymentByIdForAllCustomers(ocp, auth, "812d2c17-5f69-49ac-9f15-36616b1a154f" );
        }

        //812d2c17-5f69-49ac-9f15-36616b1a154f



        [TestMethod]
        public async Task TestMethodPostPayment()
        {
            var f = new BlueBank.BlueBankAccounts();

            var payment = new BlueBank.DataTypes.Payment.Payment();

            payment.paymentType = "XFR";
                payment.fromAccountId = accountid;
                payment.toSortCode = "839999";

            //839999 10002283
                payment.toAccountNumber = "10002283";
                payment.paymentReference = "College Fund";
                payment.paymentAmount = 600.1F;
                payment.paymentCurrency = "GBP";
            


            var r = await f.PaymentCreate(ocp, auth, payment);
        }

        [TestMethod]
        public async Task TestWebHookFilters_GetAll()
        {
            var f = new BlueBank.BlueBankAccounts();
            var r = await f.GetWebHookFilters_GetAll(ocp, auth);
        }

        [TestMethod]
        public async Task GetWebHookRegistrations_GetAllForCustomer()
        {
            var f = new BlueBank.BlueBankAccounts();
            var r = await f.GetWebHookRegistrations_GetAllForCustomer(ocp, auth);
        }

        [TestMethod]

        public async Task TestPostWebHookRegistrations_Create()
        {
            var f = new BlueBank.BlueBankAccounts();
            var webhook = new WebHookRegister();

            List<string> filters = new List<string>();
            filters.Add("*");
            webhook.filters = filters.ToArray();
            webhook.webHookUri = "http://example.io";
            var r = await f.PostWebHookRegistrations_Create(ocp, auth, webhook);
        }
    }
}
