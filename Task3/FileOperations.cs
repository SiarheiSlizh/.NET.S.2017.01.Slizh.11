using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Class contains some file operations.
    /// </summary>
    public static class FileOperations
    {
        /// <summary>
        /// find number of words in the file
        /// </summary>
        /// <param name="path">the whole path to file</param>
        /// <param name="word">necessary word</param>
        /// <returns></returns>
        public static int CountWords(string path, string word)
        {
            if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(word))
                throw new ArgumentNullException();

            try
            {
                using (StreamReader file = new StreamReader(path, Encoding.UTF8))
                {
                    return file.ReadToEnd().ToLower().Split(new[] { word }, StringSplitOptions.None).Length - 1;
                }
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
        }
    }
}
