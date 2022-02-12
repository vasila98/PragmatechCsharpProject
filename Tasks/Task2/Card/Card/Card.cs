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
        public static string kod;

        public static void KartinKodunuELaveEt()
        {
          
            Random random = new Random();
            string a="";
            for (int i = 0; i < 16; i++)
            {

               
                long kod = random.Next(9);
                kod.ToString();
                a += kod;


            }
            Console.WriteLine("kartinizin 16 xanali kodu : "+ a);
         
          

        }
        public static void KartaPulElaveEt()
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
