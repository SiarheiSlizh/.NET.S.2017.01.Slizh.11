using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3Tests
{
    [TestFixture]
    public class FileOperationsTests
    {
        [TestCase("E:\\library\\file.txt", "private", ExpectedResult = 2)]
        [TestCase("E:\\library\\file.txt", "schools", ExpectedResult = 8)]
        [TestCase("E:\\library\\file.txt", "parents", ExpectedResult = 1)]
        [TestCase("E:\\library\\file.txt", "public", ExpectedResult = 5)]
        [TestCase("E:\\library\\file.txt", "pupils", ExpectedResult = 2)]
        [TestCase("E:\\library\\file.txt", "crazy", ExpectedResult = 0)]
        public int FileOperations_PositiveTests(string path, string word)
        {
            return FileOperations.CountWords(path, word);
        }

        [TestCase("E:\\library\\file.txt", null)]
        [TestCase("", "private")]
        public void FileOperations_ArgumentNullExceptions(string path, string word)
        {
            Assert.Throws<ArgumentNullException>(() => FileOperations.CountWords(path, word));
        }
    }
}
