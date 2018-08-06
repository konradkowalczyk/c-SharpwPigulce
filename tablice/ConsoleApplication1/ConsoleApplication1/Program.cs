using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new int[,] {
                {0,1,2 },
                {3,4,5 },
                {6,7,8 }
                };
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
