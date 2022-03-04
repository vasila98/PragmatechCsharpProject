using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NN.Vesi.Adgoster("vesi",22);
            BB.Vesi.Adgoster("hesen", 55);


        }
    }
}
namespace NN
{
    public class Vesi
    {
        public string Name;
        public int Age;

        public static void Adgoster(string nm, int yas)
        {
           
            Console.WriteLine(nm+" "+yas);
        }
    }

}
namespace BB
{
    public class Vesi
    {

        public string Name;
        public int Age;

        public static void Adgoster(string nm, int yas)
        {
            
            Console.WriteLine(nm + " " + yas);
        }
      
    }

}
