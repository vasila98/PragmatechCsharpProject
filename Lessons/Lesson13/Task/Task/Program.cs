using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa bir emeliyyat secin:");
            Console.WriteLine("1.Kvadratin perimetrini ve sahesini gosterir");
            Console.WriteLine("2.Duzbucaqlinin perimetrini ve sahesini gosterir");
            Console.WriteLine("3.Ucbucagin perimetrini ve sahesini gosterir");
            Console.WriteLine("4.Dairenin perimetrini ve sahesini gosterir");
            string secim=Console.ReadLine();
            if (secim == "1")
            {
                Square square = new Square();
                square.CalculatePerimeter(5);
                square.CalculateArea(5);

            }
            else if (secim == "2")
            {
                Rectangle rect = new Rectangle();
                rect.CalculatePerimeter(5, 6);
                rect.CalculateArea(5,6);
            }
            else if (secim == "3")
            {
                Triangle triangle = new Triangle(); 
                triangle.CalculatePerimeter(5,6,7);
                triangle.CalculateArea(5,6);
            }
            else if (secim == "4")
            {
                Circle circle = new Circle();
                circle.CalculatePerimeter(5);
                circle.CalculateArea(5);
                   
            }
            else
            {
                Console.WriteLine("bele bir emeliyyat movcud deyil");
            }
           
           
        }
        interface IFigure
        {
            void CalculateArea(int a);
            void CalculateArea(int a,int b);
            void CalculateArea(int a,int b, int c);


            void CalculatePerimeter(int a);
            void CalculatePerimeter(int a, int b);
            void CalculatePerimeter(int a, int b, int c);
        }
        class Square : IFigure
        {
            public void CalculateArea(int a)
            {
                int hasil = a * a;
                Console.WriteLine("kvadratin sahesi"+" "+hasil);
            }

            public void CalculateArea(int a, int b)
            {
                throw new NotImplementedException();
            }

            public void CalculateArea(int a, int b, int c)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a)
            {
                int pm = 4 * a;
                Console.WriteLine("kvadratin perimetri"+" "+pm);
            }

            public void CalculatePerimeter(int a, int b)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a, int b, int c)
            {
                throw new NotImplementedException();
            }
        }
        class Rectangle : IFigure
        {
            public void CalculateArea(int a)
            {
                throw new NotImplementedException();
            }

            public void CalculateArea(int a, int b)
            {
                int sahe = a * b;
                Console.WriteLine("duzbucaqlinin sahesi" + " " + sahe);

            }

            public void CalculateArea(int a, int b, int c)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a, int b)
            {
                int pm = 2 * (a+b);
                Console.WriteLine("duzbucaqlinin  perimetri" + " " + pm);

            }

            public void CalculatePerimeter(int a, int b, int c)
            {
                throw new NotImplementedException();
            }
        }
        class Triangle : IFigure
        {
            public void CalculateArea(int a)
            {
                throw new NotImplementedException();
            }

            public void CalculateArea(int a, int b)
            {
                int sahe=(a * b)/2;
                Console.WriteLine("ucbucagin  sahesi" + " " + sahe);
            }

            public void CalculateArea(int a, int b, int c)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a, int b)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a, int b, int c)
            {
                int pm=2* (a+b+c);
                Console.WriteLine("ucbucagin  perimetri" + " " + pm);

            }
        }
        class Circle : IFigure
        {
            public void CalculateArea(int a)
            {
                float pi = 3.14F;
                float hasil = a* a * pi;
                Console.WriteLine("dairenin sahesi"+" "+hasil);
            }

            public void CalculateArea(int a, int b)
            {
                throw new NotImplementedException();
            }

            public void CalculateArea(int a, int b, int c)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a)
            {
                float pi = 3.14F;
                float pm = 2 * pi * a;
                Console.WriteLine("dairenin perimetri"+" "+pm);
            }

            public void CalculatePerimeter(int a, int b)
            {
                throw new NotImplementedException();
            }

            public void CalculatePerimeter(int a, int b, int c)
            {
                throw new NotImplementedException();
            }
        }
    }
}
