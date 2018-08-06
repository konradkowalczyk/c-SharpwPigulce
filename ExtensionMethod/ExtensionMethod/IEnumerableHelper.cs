using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class IEnumerableHelper
    {
        public static T First<T>(this IEnumerable<T> sequence)
        {
            foreach (T element in sequence)
            {
                return element;
            }
            throw new InvalidOperationException("Brak elementów!");
        }
    }
}
