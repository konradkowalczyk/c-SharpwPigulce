using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] reals = { 1.3f, 1.5f, 1.8f};

            int[] wholes = Array.ConvertAll(reals, x => Convert.ToInt32(x));
        }
    }
}
