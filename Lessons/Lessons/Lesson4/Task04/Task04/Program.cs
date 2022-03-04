using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yasinizi daxil edin : ");
            int yas=Convert.ToInt32(Console.ReadLine());
            if (yas < 30 && yas>0)
            {
                Console.WriteLine("Yasinizin kvadrati : ");
                Console.WriteLine(yas * yas);
            }
            else if (30 < yas && yas < 40 && yas>0)
            {
                yas = yas % 10;
                Console.WriteLine(yas);
            }
            else if (yas>40 && yas<100)
            {
                Console.WriteLine("Yasiniz: " + yas);

            }
            else 
            {
                Console.WriteLine("Duzgun melumat daxil etmemisiniz");

            }
        }
    }
}
