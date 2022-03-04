using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Cixma");
            Console.WriteLine("3.Vurma");
            Console.WriteLine("4.Bolme");
            Console.WriteLine("Yerine yetirmek istediyiniz emeliyyati daxil edin: ");

            int hesab=Convert.ToInt32(Console.ReadLine());
           
            
           

            
            switch (hesab)
            {
                case 1:
                    {
                        Console.WriteLine("Birinci ededi daxil edin: ");
                        var birinciEded = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin: ");
                        var ikinciEded = Convert.ToInt32(Console.ReadLine());
                        int cavab= Toplama(birinciEded, ikinciEded);
                        Console.WriteLine( "cavab = " + cavab);
                        break;
                        
                    }
                case 2:
                    {
                        Console.WriteLine("Birinci ededi daxil edin: ");
                        var birinciEded = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin: ");
                        var ikinciEded = Convert.ToInt32(Console.ReadLine());
                        int cavab = Cixma(birinciEded, ikinciEded);
                        Console.WriteLine("cavab = " + cavab);
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("Birinci ededi daxil edin: ");
                        var birinciEded = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin: ");
                        var ikinciEded = Convert.ToInt32(Console.ReadLine());
                        int cavab = Vurma(birinciEded, ikinciEded);
                        Console.WriteLine("cavab = " + cavab);
                        break;

                    }
                case 4:
                    {
                        Console.WriteLine("Birinci ededi daxil edin: ");
                        var birinciEded = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin: ");
                        var ikinciEded = Convert.ToInt32(Console.ReadLine());
                        int cavab = Bolme(birinciEded, ikinciEded);
                        Console.WriteLine("cavab = " + cavab);
                        break;

                    }
                default:
                    Console.WriteLine("Duzgun reqem daxil edin!");
                    break;
            }
        }
        public static int Toplama(int first, int second)
        {
            int result =first+ second;
            return result;
        }
        public static int Cixma(int first, int second)
        {
            int result = first - second;
            return result;
        }
        public static int Vurma(int first, int second)
        {
            int result = first * second;
            return result;
        }
        public static int Bolme(int first, int second)
        {
            int result = first / second;
            return result;
        }
    }
}
