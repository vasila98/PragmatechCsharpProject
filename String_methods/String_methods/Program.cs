using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = "  Mene hami Vesi deyir  ";
            cumle = cumle.ToUpper();
            Console.WriteLine(cumle);   
            cumle = cumle.ToLower();
            Console.WriteLine(cumle);
            cumle = cumle.Trim();
            Console.WriteLine(cumle);
            bool isContains = cumle.Contains("vesi");
            Console.WriteLine(isContains);
            string username = "  ";
            Console.WriteLine(String.IsNullOrWhiteSpace(username));
        }
    }
}
