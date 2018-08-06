using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaClosure
{
    class Program
    {
        static void Main(string[] args)
        {
            int factor = 2;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(3));
            Console.ReadKey();

        }
    }
}
