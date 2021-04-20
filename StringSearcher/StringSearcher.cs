using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class StringSearcher
    {
        public static bool f_is = false;
        public delegate void Word(string word);
        Word wrd = Print;


        public void Search(List<string> str)
        {
            Console.WriteLine("Введите искомое слово");
            string word = Console.ReadLine();
            foreach (string s in str)
            {
                if (word == s)
                {
                    f_is = true;
                }
            }
            wrd(word);
        }

        private static void Print(string word)
        {
            if (f_is == true)
            {
                Console.WriteLine($"Искомое слово {word} есть в списке");
            }
            else
            {
                Console.WriteLine("Искомое слово отсутствует");
            }
        }

    }
}
