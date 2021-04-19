using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class StringSearcher
    {
        public static void Search(List<string> str)
        {
            foreach (string s in str)
            {
                Console.WriteLine($"Слово {s.} состоит из {s.Length} букв");
            }
        }
    }
}
