using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using CurrencyConverter.Services.Model;
using CurrencyConverter.services;
using CurrencyConverter.services.ICurrencyConverter;

namespace CurrencyConverter.Services.CurrencyLogic
{
    public class CurrencyLogic : ICurrencyConverterLogic
    {
        public double ConvertCurrency(CurrencyModel model)
        {
            double convertedTotal = 0.0;
            double AmountToConvert = model.Amount;
            double dollarToEuro = 0.91;
            double euroToDollar = 1.10;
            double dollarsToNgn = 1.636;
            double euroToNgn = 1.835;
            double NgnToDollars = 0.0006;
            double NgnToEuro = 0.0005;

            if (model.FromCurrency == model.ToCurrency)
            {
                convertedTotal = model.Amount;
            }
            if (model.FromCurrency == "USD")

            {
                if (model.ToCurrency == "EUR")
                {
                    convertedTotal = AmountToConvert * dollarToEuro;
                }
                if (model.ToCurrency == "NGN")
                {
                    convertedTotal = AmountToConvert * dollarsToNgn;
                }
            }
            if (model.FromCurrency == "EUR")
            {
                if (model.ToCurrency == "USD")
                {
                    convertedTotal = AmountToConvert * euroToDollar;
                }
                if (model.ToCurrency == "NGN")
                {
                    convertedTotal = AmountToConvert * euroToNgn;
                }
            }
            if (model.FromCurrency == "NGN")
            {
                if (model.ToCurrency == "USD")
                {
                    convertedTotal = AmountToConvert * NgnToDollars;
                }
                if (model.ToCurrency == "EUR")
                {
                    convertedTotal = AmountToConvert * NgnToEuro;
                }
            }
            return convertedTotal;
        }

       
    }
}

