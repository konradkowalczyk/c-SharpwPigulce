using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametry
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = null;
            Console.WriteLine(a?.First() == null ? true : false);
            Console.ReadKey();
        }

        public static void haha(params int[] numbers)
        {
            var b = numbers?.First();
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}
