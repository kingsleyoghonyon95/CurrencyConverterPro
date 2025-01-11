using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Services.Model
{
    public class CurrencyModel
    {
        public string? FromCurrency { get; set; }
        public string? ToCurrency { get; set; }
        public decimal Amount { get; set; }
        public List<string>? CurrencyList { get; set; } 
        public int ConvertedResult { get; set; }
        public decimal EUR { get; set; }
        public decimal USD { get; set; }
        public decimal NGN { get; set; }

        public CurrencyModel()
        {

        }

    }


}
