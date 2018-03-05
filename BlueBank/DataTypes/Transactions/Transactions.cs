using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.DataTypes.Transactions
{

    public class Transactions
    {
        public Result[] results { get; set; }
        public Meta meta { get; set; }
    }

    public class Meta
    {
        public string total { get; set; }
        public string count { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public DateTime transactionDate { get; set; }
        public string transactionDescription { get; set; }
        public decimal transactionAmount { get; set; }
        public string transactionCurrency { get; set; }
    }

}
