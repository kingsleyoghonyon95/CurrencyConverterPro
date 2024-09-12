using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.services.models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Rates
    {
        public double EUR { get; set; }
        public double GBP { get; set; }
    }

    public class Root
    {
        public string @base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
        public bool success { get; set; }
        public int timestamp { get; set; }
    }
   


  

}
