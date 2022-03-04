using System;
using System.Collections;

namespace Ref_ve_out
{
    class Program
    {
        static void Main(string[] args)
        {



            int a = 5;
           
           
            ChangeNumber( ref a);
            Console.WriteLine(a);
            Console.ReadLine();



        }






        static void ChangeNumber(ref int num)
        {

            num++;
            

        }
    }
}
