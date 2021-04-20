using System;
using System.Collections.Generic;

namespace StringSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringSearcher word = new StringSearcher();
            word.Print += DisplayMessage;
            string s = null;
            Console.WriteLine("Введите список слов");

            List<string> str = new List<string>();
            while (s != "стоп")
            {
                s = Console.ReadLine();
                str.Add(s);
            }
            word.Search(str);
            Console.ReadKey();
        }
        private static void DisplayMessage(string word)
        {
            Console.WriteLine(word);
        }

    }
}
