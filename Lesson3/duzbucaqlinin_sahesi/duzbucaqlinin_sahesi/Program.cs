using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duzbucaqlinin_sahesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duzbu8caqlinin enini daxil edin: ");
            int eni=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duzbubaqlinin uzunlugunu daxil edin: ");
            int uzunlugu=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duzbucaqlinin sahesi :");
            Console.WriteLine(Sahe(eni,uzunlugu));
            Console.WriteLine("Duzbucaqlinin perimetri :");


            Console.WriteLine(Perimetr(eni, uzunlugu));
        }
        public static int Sahe(int eni, int uzunlugu)
        {
            int sahe = eni * uzunlugu;
            
            return sahe;

        }
        public static int Perimetr(int eni, int uzunlugu)
        {
            int perimetr = 2 * (eni + uzunlugu);

            return perimetr;

        }
    }
}
