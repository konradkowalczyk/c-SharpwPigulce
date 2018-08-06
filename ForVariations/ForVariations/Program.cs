using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForVariations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            for (var i = 0; i < 5 ; i++)
            {
                counter++;
            }
            Console.WriteLine(counter);
            Console.ReadKey();
            Singleton.Instance.DoWork();
        }
    }
}
