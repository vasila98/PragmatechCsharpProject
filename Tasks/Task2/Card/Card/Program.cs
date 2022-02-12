using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card.KartaPulElaveEt();
            Card.KartinKodunuELaveEt();
          
         
            while (true)
            {
               
                Console.WriteLine("1.virtual kart yaratmaq.");
                Console.WriteLine("2.virtual kartlari gosterir.");
                Console.WriteLine("3.esas kartdaki pulu gosterir.");
                Console.WriteLine("4.Cixis");
                Console.WriteLine("bir reqem secin");
                string secim=Console.ReadLine();
              
                if ( secim == "1")
                {
                    if (Card.Mebleg != 0)
                    {
                        Console.WriteLine("kartda ne qeder pul var");
                        int pul=Convert.ToInt32(Console.ReadLine());
                        VirtualCard card=new VirtualCard(pul);
                        VirtualCard.Kartlar(card);
                        
                    }
                    else
                    {
                        Console.WriteLine("kartinizda pul qalmayib.");
                    }
                    
                   
                   
                }
                else if (secim == "2")
                {
                    VirtualCard.VirtualKartlariGoster();
                }
                else if (secim == "3")
                {
                    Card.KartdakiPuluGoster();
                }
                else if (secim == "4")
                {
                    Console.WriteLine("emeliyyat sona catmisdir.");
                    break;
                }
            }

           
            
        }
    }
}
