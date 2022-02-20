using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = { "Rehman", "Aysel", "Vesi", "Elmar" };
            string ad =" ";
            foreach (string a in adlar)
            {
                ad += a[0];
            }
           
           
            Console.WriteLine(ad);
            
        }
    }
}
