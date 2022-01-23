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
            Dictionary<string,string> olkevepytxt=new Dictionary<string, string>();
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("Hormetli istifadeci! Zehmet olmasa olke adini qeyd edin: ");
                string olke=Console.ReadLine();
                Console.WriteLine("Hormetli istifadeci! Zehmet olmasa olkeye aid paytaxti qeyd edin: ");
                string paytaxt=Console.ReadLine();
                olkevepytxt.Add(olke, paytaxt);
                
              
             

            }
            Console.WriteLine("Hormetli istifadeci! Zehmet olmasa paytaxtini tapmaq istediyiniz olkenin adini qeyd edin: ");
            string olkead=Console.ReadLine();
            foreach (var item in olkevepytxt)
            {
                if (item.Key == olkead)
                {
                    Console.WriteLine(item.Value);
                }
                else if (olkead== "all")
                {
                    Console.WriteLine(item.Value);
                }
            }
            Console.WriteLine("Yeni paytaxt axtarilsin? Y/N");
            string yes = "y";
            string no = "n";
            string son=Console.ReadLine();
            if (son == yes)
            {
                Console.WriteLine("Olkenin adini daxil edin: ");
                string olkeadi = Console.ReadLine();
                foreach (var item in olkevepytxt)
                {
                    if (item.Key == olkeadi)
                    {
                        Console.WriteLine(item.Value);
                    }
                }

            }
            else if(son == no)
            {
                Console.WriteLine("Emeliyyat sona catmisdir");
                
                
            }

        }
    }
}
