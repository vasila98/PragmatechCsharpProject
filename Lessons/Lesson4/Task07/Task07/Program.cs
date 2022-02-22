using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 98, 73, 6 };
            Console.WriteLine("Array-in daxilinde min eded: ");
            Console.WriteLine(numbers.Min()); 
        }
    }
}
