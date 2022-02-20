using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            a = 666;
            a = 'g';
            dynamic b = 5;
            b = 6;
            b = "vesi";
            b = true;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
              
        }
    }
}
