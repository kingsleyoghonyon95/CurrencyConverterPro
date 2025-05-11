using System;
using CurrencyConverter.Services.Model;


namespace CurrencyConverterPro.Models
{

    public class CurrencyConverterViewModel
    {
        public string? FromCurrency { get; set; }
        public string? ToCurrency { get; set; }
        public decimal Amount { get; set; }
        public List<string> CurrencyList { get; set; }
        public decimal ConvertedResult { get; set; }

        public CurrencyConverterViewModel()
        {
            CurrencyList =
            [
                "AUD",
                "BOB",
                "BRL",
                "CAD",
                "CDF",
                "CHF",
                "EUR",
                "GBP",
                "GHS",
                "HKD",
                "JPY",
                "LAK",
                "LYD",
                "MAD",
                "NAD",
                "NGN",
                "MNT",
                "MRU",
                "USD",
                "ZAR"
            ];
        }
    }
}   



