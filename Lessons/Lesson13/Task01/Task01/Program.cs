using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("1. Kvadratin perimetrini ve sahesini hesablamaq ");
            Console.WriteLine("2. Duzbucaqlinin perimetrini ve sahesini hesablamaq ");
            Console.WriteLine("3. Ucbucagin perimetrini ve sahesini hesablamaq ");
            Console.WriteLine("4. Dairenin perimetrini ve sahesini hesablamaq ");
            Console.WriteLine("   Zehmet olmasa bir emeliyyat secin:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("kvadratin terefini daxil edin: ");
                Kvadrat kv = new Kvadrat();
                kv.Perimetr();
                kv.Sahe();
            }
            else if (secim == "2")
            {

                Console.WriteLine("Duzbucaqlinin tereflerini daxil edin: ");
                Duzbucaqli db = new Duzbucaqli();
                db.Perimetr();
                db.Sahe();
            }
            else if (secim == "3")
            {
                Console.WriteLine("Ucbucagin tereflerini daxil edin:  ");
                Ucbucaq ucbucaq = new Ucbucaq();
                ucbucaq.Perimetr();
                ucbucaq.Sahe();

            }
            else if (secim == "4")
            {

                Console.WriteLine("Dairenin radiusunu daxil edin: ");
                Daire daire = new Daire();
                daire.Perimetr();
                daire.Sahe();

            }
            else
            {
                Console.WriteLine("Bele bir emeliyyat yoxdur. Emeliyyat sona catmisdir.");
            }










        }
        interface IFigure
        {
            void Sahe();
            void Perimetr();
        }
        class Kvadrat : IFigure
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
            public void Perimetr()
            {
                int pm = 4 * a;
                Console.WriteLine("kvadratin perimetri: " + pm);
            }

            public void Sahe()
            {
                int sahe = a * a;
                Console.WriteLine("kvadratin sahesi: " + sahe);
            }
        }
        class Duzbucaqli : IFigure
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            public void Perimetr()
            {
                int pm = 2 * (a + b);
                Console.WriteLine("Duzbucaqlinin perimetri: " + pm);
            }

            public void Sahe()
            {
                int sahe = a * b;
                Console.WriteLine("Duzbucaqlinin sahesi : " + sahe);
            }
        }
        class Ucbucaq : IFigure
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());


            public void Perimetr()
            {
                int pm = a + b + c;
                Console.WriteLine("ucbucaqlinin perimetri: " + pm);
            }

            public void Sahe()
            {
                int sahe = (a * b) / 2;
                Console.WriteLine("ucbucaqlinin sahesi: " + sahe);
            }
        }
        class Daire : IFigure
        {
            int radius=Convert.ToInt32(Console.ReadLine());
            float pi = 3.14F;
            public void Perimetr()
            {
                float pm = 2 * pi * radius;
                Console.WriteLine("dairenin perimetri: "+pm);
            }

            public void Sahe()
            {
                float sahe = pi * radius * radius;
                Console.WriteLine("dairenin sahesi: "+sahe);
            }
        }

    }
}
