﻿using CurrencyConverter.services.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.services.ApiLogic
{
    public class CurrencyLogic
    {
        public async Task<Root> GetApi(string from, string to, double amount)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                
                RequestUri = new Uri($"https://currency-converter5.p.rapidapi.com/currency/convert?format=json&from={from}&to={to}&amount={amount}&language=en"),
                Headers =
                {
                    { "x-rapidapi-key", "1fa8321012mshb5079405016f549p14dd30jsn51e13b4e18a0" },
                    { "x-rapidapi-host", "currency-converter5.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }

        }
    }
}