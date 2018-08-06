using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableYield
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibss = Fibs(6);
            foreach (int fib in Fibs(6))
            {
                Console.Write(fib + " ");
            }
        }
        static IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }
    }
}
