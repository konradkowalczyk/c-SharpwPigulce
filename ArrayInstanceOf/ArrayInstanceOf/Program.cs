using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInstanceOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Array a = Array.CreateInstance(typeof(string), new int[] { 2 }, new int[] { 1 });

            a.SetValue("a", 1);
            a.SetValue("b", 2);
            Console.WriteLine(Array.IndexOf(a, "c"));
            Console.ReadKey();

        }
    }
}
