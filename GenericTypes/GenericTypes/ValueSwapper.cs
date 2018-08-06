using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public static class ValueSwapper
    {
        public static void SwapValue<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        public static T GetDefaultValue<T>(T theValue)
        {
            return default(T);
        }
    }
}
