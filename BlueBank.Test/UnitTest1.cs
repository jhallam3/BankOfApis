using BlueBank;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace BlueBank.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public async Task Auth2AsyncTestAsync()
        {
            var f = new BlueBank.Auth();
            var d = await f.Auth2Async();
            Assert.Fail();
        }




    }
}

namespace BlueBank.Test
{
    [TestClass]
    public class UnitTest1
    {
        string ocp = "aae52a4a909d4d22ab1ee7e8e54cc00a";

        string accountid = "1a5b0078-738a-4e21-9389-156ccd362f44";

        string auth = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MjAxODg0ODAsIm5iZiI6MTUyMDE4NDg4MCwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6ImEyNjVhOWI5LWI0ZWUtNGExYy05ZmY0LWU5MDcyNGViYTFiOSIsImF1ZCI6IjQwOTU3YjljLTYzYmMtNGFiNC05ZWNiLTY3YjU0M2M4ZTRjYSIsIm5vbmNlIjoiZGVmYXVsdE5vbmNlIiwiaWF0IjoxNTIwMTg0ODgwLCJhdXRoX3RpbWUiOjE1MjAxODQ4ODAsIm9pZCI6ImEyNjVhOWI5LWI0ZWUtNGExYy05ZmY0LWU5MDcyNGViYTFiOSIsIm5hbWUiOiJKb24iLCJmYW1pbHlfbmFtZSI6IkhhbGxhbSIsImdpdmVuX25hbWUiOiJKb24iLCJlbWFpbHMiOlsiSm9uLkhhbGxhbUBNYW5hZ2VkLURlc2t0b3AuY29tIl0sInRmcCI6IkIyQ18xX0JsdWVCYW5rU1VTSSJ9.dP7fOIop2lOsg-NMKBB7T-aKk_9UGLWwhgZ9ti1gjn1SEZcr6x-yaMKroRuZSkQNX4wxh5ltwf7CKGKAUYKRZg0SWIZgcfzi9iWpz0Mlto2y4ReA7bWJJdwR_QNcnioy-_zMB1_qZTbmjzYEtvnEprjOOmR7fC_EauptqOCZyJgGh52OrEheXNj9enU480euzqbSoyOGaL0oNBo7bCaGJK9ZsZnEjPiwsdSnOIF5s4s0u1A9Fl_Bu7C07MJGxaIIvF3NO6Re7TbrKoW_drvxnqTO3CCtih0goMOOTGH1emmbBwHSiMJOaoY2t7Z_PipDGB6uMDXexvMNhBL-xIR5oQ";
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
    }
}
