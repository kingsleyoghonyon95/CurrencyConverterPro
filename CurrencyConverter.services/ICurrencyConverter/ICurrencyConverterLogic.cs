using CurrencyConverter.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.services.ICurrencyConverter
{
    public interface ICurrencyConverterLogic
    {
        public double ConvertCurrency(CurrencyModel model);

    }
}
