using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total1 = Hesab.Cem(1, 5, 7);
            Console.WriteLine(total1);

        }
       
         

    }
    public class Hesab
    {
        public static int Cem(params int[] list)
        {
            int total = 0;
            for (int i = 0; i < list.Length; i++)
            {
                total += list[i];
             

            }
            return total;
        }


    }
}
