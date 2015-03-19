namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extentions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;

            foreach (T item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;
            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }
            return result;
        }
        public static T MinValue<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Min();
        }

        public static T MaxValue<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Max();
        }
        public static double CollectionAverage<T>(this IEnumerable<T> collection) where T : struct
        {
            return (dynamic)collection.Sum() / collection.Count();
        }


    }
}
