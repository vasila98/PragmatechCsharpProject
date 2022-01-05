using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa bir reqem daxil edin:");
            
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("verilen edede qeder kvadratlari cemi: ");
            Hasil(x);

            
        }

        public static int Hasil(int kv)
        {
            int a = 0;
            int cem = 0;
            for (int i = 1; i <= kv; i++)
            {
                a = (i * i);
                cem += a;
            }
            Console.WriteLine(cem);
            return cem;
        }

       

    }
}
