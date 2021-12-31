using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin: ");
            int x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ChangeNumber(ref x));
        }

        public static int ChangeNumber(ref int input)
        {
            int result = 0;
            int sum = 0;
            for(int i = 0; i < 9; i++)
            {
                result = i * input;
                sum += result;
            }
            input = sum;
            return sum;
        }
    }
}
