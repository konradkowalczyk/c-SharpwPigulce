using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsługaZdarzeń
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("THPW");
            stock.Price = 27.10M;
            //rejestracja zdarzeń PriceChanged
            stock.PriceChanged += Stock_PriceChanged;
            stock.PriceChanged += Stock_PriceChangedDummy;
            stock.Price = 31.59M;
            Console.ReadKey();
        }

        static void Stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }

        static void Stock_PriceChangedDummy(object sender, PriceChangedEventArgs e)
        {
            Console.WriteLine("huehue");
        }
    }
}
