using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2Tests
{

    [TestFixture]
    public class SearchTests
    {
        private static DateTime[] d = new DateTime[] {
            new DateTime(2017, 3, 11),
            new DateTime(2017, 3, 19),
            new DateTime(2017, 3, 19),
            new DateTime(2017, 3, 25) };

        [TestCase(null, "Sean")]
        [TestCase(new string[] { "Ann", "Chris", "John", "Max", "Sean", "Serena" }, null)]
        public void Binary_ArgumentNullException(string[] arr, string el)
        {
            Assert.Throws<ArgumentNullException>(() => Search.Binary(arr, el));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 7, 9, 22, 34, 65, 4 }, 7, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 7, 9, 22, 34, 65, 4 }, 17, ExpectedResult = null)]
        public int? Binary_int_PositiveTests(int[] arr, int el)
        {
            return Search.Binary(arr, el);
        }

        [TestCase(ExpectedResult = 1)]
        public int? Binary_Datetime_PositiveTests()
        {
            return Search.Binary(d, d[1]);
        }

        [TestCase(ExpectedResult = null)]
        public int? Binary_Datetimenull_PositiveTests()
        {
            return Search.Binary(d, new DateTime(2017,4,22));
        }

        [TestCase(new string[] { "Ann", "Chris", "John", "Max", "Sean", "Serena" }, "Sean", ExpectedResult = 4)]
        [TestCase(new string[] { "Ann", "Chris", "John", "Max", "Sean", "Serena" }, "Sara", ExpectedResult = null)]
        public int? Binary_string_PositiveTests(string[] arr, string el)
        {
            return Search.Binary(arr, el);
        }
    }
}
