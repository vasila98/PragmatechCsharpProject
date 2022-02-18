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

            Console.WriteLine("kvadratin terefini daxil edin: ");
            Kvadrat kv = new Kvadrat();

            kv.Perimetr();
            kv.Sahe();
            Console.WriteLine("Duzbucaqlinin tereflerini daxil edin: ");
            Duzbucaqli db = new Duzbucaqli();
            db.Perimetr();
            db.Sahe();

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
    
    }
}
