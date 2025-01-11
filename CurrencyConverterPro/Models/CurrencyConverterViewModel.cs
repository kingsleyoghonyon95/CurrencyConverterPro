using System;
using CurrencyConverter.Services.Model;


namespace CurrencyConverterPro.Models
{

    public class CurrencyConverterViewModel
    {
        public string? FromCurrency { get; set; }
        public CurrencyModel? CurrentCurrency { get; set; }
        public string? ToCurrency { get; set; }
        public decimal Amount { get; set; }
        public List<string> CurrencyList { get; set; }
        public decimal ConvertedResult { get; set; }
        public decimal FromUSDToEUR { get; set; }

        public CurrencyConverterViewModel()
        {
            CurrencyList =
            [
                "USD",
                "EUR",
                "NGN"
            ];
        }

        public decimal ConvertFromUSDToEUR()
        {
            return CurrentCurrency.USD * 0.96m;
        }
    }
}   



