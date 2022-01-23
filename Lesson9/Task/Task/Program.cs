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
            for (int i = 0; i <2; i++)
            {
                Console.WriteLine("olke");
                string olke=Console.ReadLine();
                Console.WriteLine("seher");
                string paytaxt=Console.ReadLine();
                olkevepytxt.Add(olke, paytaxt);
                
              
             

            }
            Console.WriteLine("yaz");
            string olkead=Console.ReadLine();
            foreach (var item in olkevepytxt)
            {
                if (item.Key == olkead)
                {
                    Console.WriteLine(item.Value);
                }
            }
            Console.WriteLine("daxil ele");
            string yes = "y";
            string no = "n";
            string son=Console.ReadLine();
            if (son == yes)
            {
                

            }
            else if(son == no)
            {
                Console.WriteLine("sagol");
                
            }

        }
    }
}
