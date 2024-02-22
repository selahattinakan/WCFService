using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    public class RateService : IRateService
    {
        public List<string> GetCurrencies()
        {
            return new List<string> { "Dolar", "Euro" };
        }

        public double GetRate(string currencyType)
        {
            Random random = new Random();
            return random.NextDouble() + 30;// :(
        }
    }
}
