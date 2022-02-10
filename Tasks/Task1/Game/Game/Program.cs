using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[6];
            array[0] = "a";
            array[1] = "b";
            array[2] = "c";
            array[3] = "d";
            array[4] = "e";
            array[5] = "f";

           
          
            Random(array);
           

        }
       
        public static void Random(string[] soz)
        {
            int xal = 0;
            Random random = new Random();
            var index = random.Next(soz.Length);
            Console.WriteLine("yarimciq soz ");
            Console.WriteLine(soz[index] );
            Console.WriteLine("sonraki sozu daxil edin: ");
            string sozz=Console.ReadLine();  
            if( sozz == soz[index + 1])
            {
                Console.WriteLine("6 xal qazandin");
                xal = xal + 6;
            }
            else
            {
                Console.WriteLine("ikinci sansinizdir, soz daxil edin: ");
                string sozz2=Console.ReadLine();
                if ( sozz2 == soz[index + 1])
                {
                    Console.WriteLine("4 xal qzandiniz");
                    xal = xal + 4;
                }
                else
                {
                    Console.WriteLine("son sansinizdir, sozu daxil edin: ");
                    string soz3=Console.ReadLine();
                    if ((soz3 == soz[index + 1]))
                    {
                        Console.WriteLine("2 xal qazandiniz");
                        xal = xal + 2;
                    }
                    else
                    {
                        Console.WriteLine("xaliniz yoxdur");
                    }
                }
            }
            

            
        }
    }
}
