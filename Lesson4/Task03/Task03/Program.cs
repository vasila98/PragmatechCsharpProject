using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tek_Cut( 14587));
        }
        public static int Tek_Cut(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("cut ededdir");
            }
            else
            {
                Console.WriteLine("tek ededdir");
            }
            
            return a;
        }

    }
}
