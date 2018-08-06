using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivingFromObject
{
    interface ITest

    {

        void Run();

    }

    class Program

    {

        static void Main(string[] args)

        {

            if (typeof(ITest) is Object)

            {

                Console.WriteLine("ITest is an Object.");

            }

            else

            {

                Console.WriteLine("ITest is not an Object.");

            }

        }

    }
}
