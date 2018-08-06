using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticContructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo.X);
            Console.ReadKey();
        }
        class Foo
        {
            public static Foo Instance = new Foo();
            public static int X = 3;
            Foo()
            { Console.WriteLine(X); }
        }
    }
}
