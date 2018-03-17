using System;
using System.Linq;

namespace Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string ocp = "aae52a4a909d4d22ab1ee7e8e54cc00a";


            string auth = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MjEyOTMxODYsIm5iZiI6MTUyMTI4OTU4NiwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6ImEyNjVhOWI5LWI0ZWUtNGExYy05ZmY0LWU5MDcyNGViYTFiOSIsImF1ZCI6IjgzNTA1NmYzLTE1MGUtNDI5Ni1iMzIzLWMxMWRhMWVmYjhhNyIsIm5vbmNlIjoiZGVmYXVsdE5vbmNlIiwiaWF0IjoxNTIxMjg5NTg2LCJhdXRoX3RpbWUiOjE1MjEyODk1ODYsIm9pZCI6ImEyNjVhOWI5LWI0ZWUtNGExYy05ZmY0LWU5MDcyNGViYTFiOSIsIm5hbWUiOiJKb24iLCJmYW1pbHlfbmFtZSI6IkhhbGxhbSIsImdpdmVuX25hbWUiOiJKb24iLCJlbWFpbHMiOlsiSm9uLkhhbGxhbUBNYW5hZ2VkLURlc2t0b3AuY29tIl0sInRmcCI6IkIyQ18xX0JsdWVCYW5rU1VTSSJ9.IoWsrwlwY4nIUezgGa95FKU3oJqzqhYAf4JzP1nxUtUjJq3oLgtpid1bRw-70480_gQjRwjwXgNpujVfo8zPBxqOgyTZ1XB721-Ew38ym3XeqbibDCbz6LGW9jefBHlWf1yrvLaCeo9Ek9dEUUjzTwqwcb4Uyv7xBYT-xGIi8gFb1c7PcppEuQmi6qHhIc6LfXMSQHspiMaRRA67vv7tmWlhtm-SVbwKmCoeM7wryAvtuqS0-fLDJdn4TLqarGpY5rICkYiOPPHdgfP-lU6C8_QSt7T06Ptvor0tW7b3t20EmW40J6-8L9siVSNjS_n3_qbreOcvFM5rJ7DyHy8mKQ";
            var f = new BlueBank.BlueBankForDecisions();

            var b = f.GetCustomersAsync(ocp, auth);
            var c = f.GetCustomersAccounts(ocp, auth, b.results.ElementAt(0).id);


            //issue with this..... but var a = f.GetAccountByAccountIdAsync(ocp, auth, b.results.ElementAt(0).id);
            var e = f.GetPaymentsForAllCustomers(ocp, auth);
           
            var d = f.GetPaymentByIdForAllCustomers(ocp, auth,e.ElementAt(0).id);

            var g = f.GetTransactionsByAccountId(ocp, auth, c.results.ElementAt(0).id);
            var h = f.GetWebHookFilters_GetAll(ocp, auth);
            var i = f.GetWebHookRegistrations_GetAllForCustomers(ocp, auth);
            var j = f.GetWebHookRegistrations_GetByWebhookId(ocp, auth, i.ElementAt(0).id );

        }
    }
}
