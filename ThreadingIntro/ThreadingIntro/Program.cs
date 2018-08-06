using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t2 = new Thread(WriteY);
            t2.Start();
            Thread t3 = new Thread(WriteY);
            t3.Start();
            Thread t = new Thread(WriteZ);
            t.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }

            Console.ReadKey();
        }

        public static void WriteY()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("y");
            }
        }

        public static void WriteZ()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("z");
                Thread.Sleep(0);
            }
        }
    }
}
