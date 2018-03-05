using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.DataTypes.Payment
{
    public class Payment
    {
        
            public string paymentType { get; set; }
            public string fromAccountId { get; set; }
            public string toSortCode { get; set; }
            public string toAccountNumber { get; set; }
            public string paymentReference { get; set; }
            public float paymentAmount { get; set; }
            public string paymentCurrency { get; set; }
        

    }

    public class PaymentResult
    {
        public string id { get; set; }
        public string paymentType { get; set; }
        public string fromAccountId { get; set; }
        public string toSortCode { get; set; }
        public string toAccountNumber { get; set; }
        public string paymentReference { get; set; }
        public float paymentAmount { get; set; }
        public string paymentCurrency { get; set; }
        public string paymentStatus {get;set;}

    }

}
