using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class StringSearcher
    {
        public delegate string Word(string word);
        Word wrd = Print;


        
        public void Search(List<string> str)
        {
            Console.WriteLine("Введите искомое слово");
            string word = Console.ReadLine();
            foreach (string s in str)
            {
                if (word == s)
                {
                    wrd(word);
                    break;
                }
            }
        }

        private static string Print(string word)
        {
                if (true)
                {
                    return ($"Искомое слово {word} есть в списке");
                }
                else
                {
                    return ("Искомое слово отсутствует");
                }
        }

    }
}
