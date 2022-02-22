using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] array=new Book[2];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("kitabin adini daxil edin: ");
                string name=Console.ReadLine();
                if (name.Length < 3)
                {
                    Console.WriteLine("yalnis deyer daxil etmisiniz");
                    Console.WriteLine("kitabin adi 3den qisa ola bilmez");
                    Console.WriteLine("yeniden daxil edin: ");
                    string yeni=Console.ReadLine();
                    if (yeni.Length < 3)
                    {
                        Console.WriteLine("duz daxil ele dee: ");
                        string besdi=Console.ReadLine();
                        yeni = besdi;
                    }
                   
                    name = yeni;
                    
                     
                }
                Console.WriteLine("kitabin nece sehife oldugunu daxil edin:");
                int pagecount=Convert.ToInt32(Console.ReadLine());
               
                if (pagecount < 10)
                {
                    Console.WriteLine("kitabin sehifesinin sayi 10-dan az ola bilmez");
                    Console.WriteLine("sehifenin sayini yeniden daxil edin:");
                    int yeni=Convert.ToInt32(Console.ReadLine());
                    if (yeni < 10)
                    {
                        Console.WriteLine("duz daxil eleee:");
                        int besdi=Convert.ToInt32(Console.ReadLine());
                        yeni = besdi;
                    }
                    pagecount = yeni;
                }
               
                Book obyekt = new Book(name,pagecount);
                array[i] = obyekt;
             
            }
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine("kitabin adi: " + " " + array[i].Name);
                Console.WriteLine("kitabin sehifesinin sayi: " + " " + array[i].PageCount);
                
            }
            
        }
    }
}
