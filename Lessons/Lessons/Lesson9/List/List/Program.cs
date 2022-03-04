using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> reqemler = new List<int>();
            List<int> reqemler2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("reqem daxil ele: ");
                int reqem = Convert.ToInt32(Console.ReadLine());
                reqemler.Add(reqem);
            }
            for (int k = 6; k < 11; k++)
            {
                reqemler2.Add(k);
            }
            for (int h = 1; h < 6; h++)
            {
                reqemler2.Add(h);
            }



            foreach (int i in reqemler2)
            {

                Console.WriteLine("reqem..." + i);
            }

        }
    }
}
