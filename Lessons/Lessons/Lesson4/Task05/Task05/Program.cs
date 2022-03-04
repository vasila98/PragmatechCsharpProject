using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ay daxil edin :");
            string ay = Console.ReadLine();
            Aylar(ay);
        }

        static void Aylar(string ay)
        {
            switch (ay)
            {
                case "yanvar":
                    Console.WriteLine("yanvar 31 gunden ibaretdir, qis feslidir");
                    break;
                case "fevral":
                    Console.WriteLine("fevral 28 gunden ibaretdir (4 ilden bir 29 gun olur), qis feslidir");
                    break;
                case "mart":
                    Console.WriteLine("mart 31 gunden ibaretdir, yaz feslidir");
                    break;
                case "aprel":
                    Console.WriteLine("aprel 30 gunden ibaretdir, yaz feslidir");
                    break;
                case "may":
                    Console.WriteLine("may 31 gunden ibaretdir, yaz feslidir");
                    break;
                case "iyun":
                    Console.WriteLine("iyun 30 gunden ibaretdir, yay feslidir");
                    break;
                case "iyul":
                    Console.WriteLine("iyul 31 gunden ibaretdir, yay feslidir");
                    break;
                case "avqust":
                    Console.WriteLine("avqust 31 gunden ibaretdir,26-si ad gunumdu)), yay feslidir");
                    break;
                case "sentyabr":
                    Console.WriteLine("sentyabr 30 gunden ibaretdir, payiz feslidir");
                    break;
                case "oktyabr":
                    Console.WriteLine("oktyabr 31 gunden ibaretdir, payiz feslidir");
                    break;
                case "noyabr":
                    Console.WriteLine("noyabr 30 gunden ibaretdir, payiz feslidir");
                    break;
                case "dekabr":
                    Console.WriteLine("sentyabr 31 gunden ibaretdir, qis feslidir");
                    break;
                case "":
                    Console.WriteLine("zehmet olmasa ay daxil edin!");
                    break;

            }
        }

    }
}