using RateApp.RateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (RateServiceClient serviceClient = new RateServiceClient())
            {
                var currencies = serviceClient.GetCurrencies();

                foreach (var currency in currencies)
                {
                    double value = serviceClient.GetRate(currency);
                    Console.WriteLine($"{currency} : {value:F2}");
                    System.Threading.Thread.Sleep(1000);
                }
                serviceClient.Close();
            }
            Console.ReadLine();
        }
    }
}
