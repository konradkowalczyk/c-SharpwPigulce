using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(((double)4).Power(2).Power(2));
            Console.ReadKey();
        }
    }

    public static class PowerHelper
    {
        public static double Power(this double i, double rootBase)
        {
            if (rootBase == 0)
                return 1;
            for (int j = 1; j < rootBase; j++)
            {
                i *= i;
            }
            return i;
        }
    }

    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);

        }
    }
        
}
