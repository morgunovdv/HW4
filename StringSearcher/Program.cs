using System;
using System.Collections.Generic;

namespace StringSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            List<string> str = new List<string>();
            while (s != "стоп")
            {
                s = Console.ReadLine();
                str.Add(s);
            }
            StringSearcher.Search(str);
            Console.ReadKey();
        }
    }
}
