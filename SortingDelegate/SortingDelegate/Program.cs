using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDelegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var liczby = new int[4] { 1, 2, 3, 4 };

            Array.Sort(liczby, (x, y) => x < y ? 1 : x == y ? 0 : -1);
        }
    }
}
