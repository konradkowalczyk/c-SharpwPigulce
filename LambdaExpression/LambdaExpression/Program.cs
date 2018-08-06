using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> sqr = x => x * x;
            Console.WriteLine(sqr(4));
            Func<int> hoho = () => 2;
            Console.WriteLine(hoho());
            Console.ReadKey();

        }
    }
}
