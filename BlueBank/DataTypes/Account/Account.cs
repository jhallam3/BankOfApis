using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.DataTypes.Account
{
    public class Account
    {
        public Result[] results { get; set; }
        public meta meta { get; set; }
    }

    public class meta
    {
        public string total { get; set; }
        public string count { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string sortCode { get; set; }
        public string accountNumber { get; set; }
        public string accountType { get; set; }
        public string accountFriendlyName { get; set; }
        public float accountBalance { get; set; }
        public string accountCurrency { get; set; }
    }
}
