﻿using System;
using CurrencyConverter.services.ICurrencyConverter;
using CurrencyConverter.Services.CurrencyLogic;
using CurrencyConverter.Services.Model;
using CurrencyConverterPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverterPro.Controllers
{
    public class CurrencyConverterController : Controller
    {
        private readonly ICurrencyConverterLogic _logic;

        public CurrencyConverterController(ICurrencyConverterLogic logic)
        {
            _logic = logic;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new CurrencyConverterViewModel();
            return View(model);
        }

        public IActionResult WelcomePage ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Convert(CurrencyConverterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currency = new CurrencyModel
                {
                    FromCurrency = model.FromCurrency,
                    ToCurrency = model.ToCurrency,
                    Amount = model.Amount
                };

                double convertedAmount = _logic.ConvertCurrency(currency);
                model.ConvertedResult = Math.Round(convertedAmount, 2);

                // Return the view with the updated model
                return View("Index", model);
            }

            // If model state is not valid, return the view with validation errors
            return View("Index", model);
        }
    }
}
