using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Card
    {
        public long Kod;
        public int Mebleg;
        public string Vaxt;

        public Card(long kd, int mebleg,string vxt)
        {
            Kod = kd;
            Mebleg = mebleg;    
            Vaxt = vxt;
           
        }

        public static void CreateCard()
        {
            Console.WriteLine( "ne qeder mebleg ayirmisiniz: ");
            int mebleg=Convert.ToInt32(Console.ReadLine());
            if ( )
            {

            }
            Console.WriteLine("16 xanali kodu daxil edin: ");
            double kod=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ne qeder muddetlik kart isteyirsiz");
            string vaxt=Console.ReadLine();
        }

       


    }
}
