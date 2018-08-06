using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLocal
{
    public class Zip
    {
        public void Execute()
        {
            int[] numbers = { 3, 5, 7 };
            string[] words = { "trzy", "pięć", "siedem" };

            var result = numbers.Zip(words, (n,w) => n + " = " + w);
        }
    }
}
