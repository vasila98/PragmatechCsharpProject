using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soz ="vesi";
            Console.WriteLine(Reverse(soz));


        }

        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            string soz = "";
            for (int i =charArray.Length-1; i> -1; i--)
            {
               soz+=charArray[i];

            }
            return soz;
        }
        
   
    }
}
