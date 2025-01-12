﻿using Newtonsoft.Json;
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
        public decimal ConvertCurrency(CurrencyModel model)
        {
            decimal convertedTotal = 0.0m;
            decimal AmountToConvert = model.Amount;
            decimal dollarToEuro = 0.96m;
            decimal euroToDollar = 1.10m;
            decimal dollarsToNgn = 1.636m;
            decimal euroToNgn = 1.835m;
            decimal NgnToDollars = 0.0006m;
            decimal NgnToEuro = 0.0005m;

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

