using CurrencyConverter.services.ApiLogic;
using CurrencyConverter.services.models;
using CurrencyConverterPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace CurrencyConverterPro.Controllers
{
    public class CurrencyConverterController : Controller
    {
        private CurrencyLogic? _service;

        public CurrencyConverterController()
        {
            _service = new CurrencyLogic();
        }



        public IActionResult Index()
        {
            CurrencyConverterViewModel converterViewModel = new();
       
            
            return View(converterViewModel);
        }

        public async Task<IActionResult> GetCurrency(string from, string to, double amount)
        {
            Root? result = await _service!.GetApi(from, to, amount);

            var model = new CurrencyConverterViewModel
            {
                @base = result?.@base,
                USD = result?.rates?.USD,
                EUR = result?.rates?.EUR,
                NGN = result?.rates?.NGN,
                GBP = result?.rates?.GBP,
                QAR = result?.rates?.QAR,
                CAD = result?.rates?.CAD,

            };
            
            
            return View("Index",model);
        }
    }
}

