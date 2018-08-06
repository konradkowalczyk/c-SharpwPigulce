using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    public class Util
    {
        public delegate T Transformer<T> (T arg);

        public static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (var i = 0; i < values.Length; i++)
                values[i] = t (values[i]);
        }
    }
}
