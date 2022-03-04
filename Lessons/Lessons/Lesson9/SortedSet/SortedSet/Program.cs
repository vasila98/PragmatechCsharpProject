using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("reqem daxil edin: ");
                int reqem = Convert.ToInt32(Console.ReadLine());
                set.Add(reqem);
            }
            Console.WriteLine("reqemler: ");
            foreach (int i in set)
            {

                Console.WriteLine(i);
            }


        }
    }
}
