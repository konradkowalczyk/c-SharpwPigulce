using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Program
    {
        public static void Square(int x) => Console.WriteLine(x * x);
        
        public delegate void ha(int x);
        public static ha ha4 = new ha(Square) + new ha(Square) + new ha(Square) + new ha(Square);

        static void Main(string[] args)
        {
            ha4.Invoke(1);
            Console.ReadKey();
        }

        
    }
}
