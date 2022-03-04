using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // classin obyekti
            Account obyekt = new Account("vesi", "vesi123");
            obyekt.StaticsizMetod();
            Console.WriteLine(Account.StaticReturn(5, 6));
            Account.StaticVoid();
            Console.WriteLine(obyekt.Name);
        }
    }
}
