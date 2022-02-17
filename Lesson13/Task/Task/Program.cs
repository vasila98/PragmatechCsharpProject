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
            Console.WriteLine("Interface");
        }
        interface Developer
        {
            void Maaslar(int kohne, int artmis);
            void Tasklar(string junior, string middle);
        }
    }
}
