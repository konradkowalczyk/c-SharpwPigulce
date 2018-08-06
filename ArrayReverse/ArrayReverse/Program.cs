using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chars = "abcd".ToCharArray();
            
             chars.Reverse();

            Array.Reverse(chars);
        }
    }
}
