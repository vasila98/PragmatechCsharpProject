using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Card
    {
        public static int Mebleg;
        public static void KartaElaveEt()
        {
            Console.WriteLine("kartinizda ne qeder pul oldugunu daxil edin: ");
            Mebleg=Convert.ToInt32(Console.ReadLine());

        }

        public static void KartdakiPuluGoster()
        {
            Console.WriteLine("sizin kartinizda"+" "+ Mebleg +" "+ "Azn" +" "+ "pul var.");
        }
       
       


    }
}
