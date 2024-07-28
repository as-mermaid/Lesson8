using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\\Google files\Text.txt";
            string text = "";

            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            int charCount = text.Count();

            string[] words = text.Split();
            int wordCount = words.Count();

            string[] lines = text.Split('\n');
            int linesCount = lines.Count();

            Console.WriteLine("Файл содержит {0} символов, {1} слов и {2} строк", charCount, wordCount, linesCount);
            Console.ReadKey();
        }
    }
}
