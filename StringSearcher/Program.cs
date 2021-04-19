using System;
using System.Collections.Generic;

namespace StringSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringSearcher str1 = new StringSearcher();
            string s = null;
            Console.WriteLine("Введите список слов");

            List<string> str = new List<string>();
            while (s != "стоп")
            {
                s = Console.ReadLine();
                str.Add(s);
            }
            str1.Search(str);
            Console.ReadKey();
        }
    }
}
