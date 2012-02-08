using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvManager.Extensions
{
    public static class IEnumerableE
    {
        public static string Intercalate(this IEnumerable<string> strings, string separator)
        {
            return strings.Aggregate((s, a) => a + separator + s);
        }

        public static D MaxBy<D,C>(this IEnumerable<D> source, Func<D, C> selector)
            where C : IComparable<C>
        {
            var e = source.GetEnumerator();
            e.MoveNext();

            var tmpD = e.Current;
            var tmpC = selector(tmpD);

            while (e.MoveNext())
            {
                var curD = e.Current;
                var curC = selector(curD);

                if (curC.CompareTo(tmpC) > 0)
                {
                    tmpD = curD;
                    tmpC = curC;
                }
            }

            return tmpD;
        }
    }
}
