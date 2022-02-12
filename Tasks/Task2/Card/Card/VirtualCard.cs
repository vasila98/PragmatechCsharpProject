using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class VirtualCard
    {
        public int mebleg;
        public string kod;
        static List<VirtualCard> list=new List<VirtualCard>();
        public VirtualCard(int pul)
        {
            while (Card.Mebleg < pul)
            {
                Console.WriteLine("esas kartinizda bu qeder pul yoxdur teesuf ki..");
                
                Console.WriteLine("yeniden cehd edin");
                pul=Convert.ToInt32(Console.ReadLine());
            }
            mebleg = pul;
            Card.Mebleg -= mebleg;
            Random random = new Random();
            string a = "";
            for (int i = 0; i < 16; i++)
            {


                long kod = random.Next(9);
                kod.ToString();
                a += kod;


            }
            Console.WriteLine("kartinizin 16 xanali kodu : " + a);
        }
        public static void Kartlar(VirtualCard kart)
        {
            if(list.Count < 5)
            {
                list.Add(kart);
                Console.WriteLine("sizin virtual kartiniz elave olundu");
            }
            else
            {
                Console.WriteLine("sadece 5 kart yarada bilersiniz");
            }
        }
        public static void VirtualKartlariGoster()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("siz virtual kart yaratmamisiniz");

            }
            else
            {
                for (int i = 0;i < list.Count; i++)
                {
                    int num = i + 1;
                    Console.WriteLine(num+"-ci Virtual Kartda"+" "+list[i].mebleg+" "+"Azn pul var");
                }
            }
            
        }
    }
}
