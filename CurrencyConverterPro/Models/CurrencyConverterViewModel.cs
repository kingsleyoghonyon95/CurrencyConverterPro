using System;
using CurrencyConverter.Services.Model;


namespace CurrencyConverterPro.Models
{

    public class CurrencyConverterViewModel
    {
        public string? FromCurrency { get; set; }
        public string? ToCurrency { get; set; }
        public double Amount { get; set; }
        public List<string> CurrencyList { get; set; }
        public double ConvertedResult { get; set; }

        public CurrencyConverterViewModel()
        {
            CurrencyList =
            [
                "USD",
                "EUR",
                "NGN"
            ];
        }
    }
}   



