using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "vesi";
            Console.WriteLine(SubString(word,0,4));
        }

        public static string SubString(string word, int index, int finish)
        {
            string newWord = "";
            for(int i = index; i < finish; i++)
            {
                newWord += word[i];
            }
            return newWord;
        }
    }
}
