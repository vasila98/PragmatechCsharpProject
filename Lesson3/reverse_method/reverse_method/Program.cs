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
            Console.WriteLine("Bir eded daxil edin:");
            int eded=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tersine yazilis:");
            Reverse(eded);


        }

        public static int Reverse(int eded)
        {
            for (int i = eded; eded> -1; eded--)
            {
                Console.WriteLine(i--);

            }
            return eded;
        }
        
   
    }
}
