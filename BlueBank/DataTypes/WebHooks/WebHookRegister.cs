using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.DataTypes.WebHooks
{
  

    public class WebHookRegister
    {
        public string id { get; set; }
        public string webHookUri { get; set; }
        public string secret { get; set; }
        public string description { get; set; }
        public List<string> filters { get; set; }
    }

}
