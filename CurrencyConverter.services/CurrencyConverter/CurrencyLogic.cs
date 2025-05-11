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
using CurrencyConverter.services.Model;

namespace CurrencyConverter.Services.CurrencyLogic
{
    public class CurrencyLogic : ICurrencyConverterLogic
    {
        private HttpClient _httpClient;

        public CurrencyLogic()
        {
            _httpClient = new HttpClient();

            _httpClient.BaseAddress = new Uri("https://open.er-api.com/v6/latest/");
        }

        public async Task<decimal> ConvertCurrency(CurrencyModel model)
        {
            try
            {
                var response = await _httpClient.GetAsync(model.FromCurrency);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var exchangeRate = JsonConvert.DeserializeObject<ExchangeRateResponse>(jsonResponse);

                if (exchangeRate != null && exchangeRate.Rates.ContainsKey(model.ToCurrency))
                {
                   decimal rate = exchangeRate.Rates[model.ToCurrency];
                   return model.Amount * rate;
                }
                else
                {
                    throw new Exception("Exchange rate not found");
                }

            }
            catch(Exception ex) 
            {
                throw new Exception($"Error occurred while converting: {ex.Message}");
            }
        }
    }
}

