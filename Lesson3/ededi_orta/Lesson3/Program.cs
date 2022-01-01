using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin: ");
            int birinci=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin: ");
            int ikinci=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucuncu ededi daxil edin: ");
            int ucuncu=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dorduncu ededi daxil edin: ");
            int dorduncu=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Besinci ededi daxil edin: ");
            int besinci=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ededi orta:  ");

            Console.WriteLine(EdediOrta(birinci,ikinci,ucuncu,dorduncu,besinci));
        }
        public static int EdediOrta(int birinci, int ikinci, int ucuncu, int dorduncu, int besinci)
        {
            int hesab= (birinci+ikinci+ucuncu+dorduncu+besinci)/5;
            return hesab;
        }
    }
}
