using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Class contains methods of search.
    /// </summary>
    public static class Search
    {
        /// <summary>
        /// Generic method which allows to find element any of type using key by binary method
        /// </summary>
        /// <typeparam name="T">parameter which method is closed</typeparam>
        /// <param name="arr">array of elements</param>
        /// <param name="el">criterion fo search</param>
        /// <returns>index of element in case his existing else null</returns>
        public static int? Binary<T>(T[] arr, T el)
        {
            if (ReferenceEquals(arr, null))
                throw new ArgumentNullException(nameof(arr));

            if (ReferenceEquals(el, null))
                throw new ArgumentNullException(nameof(el));

            int left = 0, 
                right = arr.Length - 1, 
                avg;

            while (left < right)
            {
                avg = (left + right) / 2;
                if (Comparer<T>.Default.Compare(el, arr[avg]) > 0) 
                    left = avg + 1;
                else right = avg;
            }
            if (Comparer<T>.Default.Compare(el, arr[left]) == 0)
                return left;
            else return null;
        }
    }
}