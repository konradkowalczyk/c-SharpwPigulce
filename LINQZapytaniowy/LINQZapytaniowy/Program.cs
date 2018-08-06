using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQZapytaniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jan", "Olga", "Daria", "Robert", "Zenon" };

            IEnumerable<string> query = from n in names where n.Contains("a") orderby n.Length select n.ToUpper();


        }
    }
}
