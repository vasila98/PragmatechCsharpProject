using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine("a= "+a );
            Console.WriteLine("b="+b);
        }
    }
}
