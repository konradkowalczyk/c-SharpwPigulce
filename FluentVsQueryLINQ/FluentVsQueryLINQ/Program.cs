using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentVsQueryLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tomek", "Darek", "Henryk", "Maria", "Janusz" };
            int[] numbers = { 1, 2, 3, 4 };
            var numbersList = numbers.ToList();

            var validated = (numbersList as IEnumerable<int>).Where2(x=>x == 2);
            var ordered = numbers.OrderBy(x => x);

            numbers.GetUpperBound(0);
        }
    }
}
