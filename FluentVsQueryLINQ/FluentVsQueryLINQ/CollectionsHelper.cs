using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentVsQueryLINQ
{
    public static class CollectionsHelper
    {
        public static IEnumerable<TSource> Where2<TSource>
             (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource element in source)
                if (predicate(element))
                    yield return element;
        }
    }
}
