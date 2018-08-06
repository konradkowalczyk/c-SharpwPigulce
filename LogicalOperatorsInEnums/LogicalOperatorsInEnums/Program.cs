using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperatorsInEnums
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sides = SidesEnum.Left | SidesEnum.Right | SidesEnum.Top | SidesEnum.Bottom;
            var sideToCheck = SidesEnum.Left;
            if ((sides & sideToCheck) != 0)
            {
                //Console.ReadKey();
            }
            var i = (2 + SidesEnum.Left);
            //i += SidesEnum.Left;
            Console.WriteLine((int)i);
            Console.ReadKey();
        }
    }
}
