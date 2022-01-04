using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Optional("Men C# oyrenmeye calisiram");
        }

        public static void Optional(string soz)
        {
             Console.WriteLine(soz.Replace(" ",""));
        }
    }
}
