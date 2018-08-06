using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 4;
            Console.WriteLine("Values before swapping: a = " + a + ", b = " + b);
            ValueSwapper.SwapValue(ref a,ref b);
            Console.WriteLine("Values after swapping: a = " + a + ", b = " + b);
            Console.WriteLine("Default value of a is " + ValueSwapper.GetDefaultValue(a));
            Console.ReadKey();
        }
    }
}
