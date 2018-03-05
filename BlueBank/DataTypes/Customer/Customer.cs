using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.DataTypes.Customer
{
    public class Customer
    {
        public Result[] results { get; set; }
        public Meta meta { get; set; }
    }

    public class Meta
    {
        public int total { get; set; }
        public int count { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
        public string address1 { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string postCode { get; set; }
        public string country { get; set; }
        public string mobilePhone { get; set; }
    }

}
