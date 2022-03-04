using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Account
    {
        public string Name;
        public string Password;
        public int No;

        public Account(string nm, string psw)
        {
            Name = nm;
            Password = psw;
        }
        // obyektle cagirmaga mecbur deyilik
        public static void StaticVoid()
        {
            Console.WriteLine("bu static void metoddur");
        }
        // verilen deyeri qaytarir
        public static int StaticReturn(int x,int y)
        {

            return x+y;
        }
        // obyektle cagirmaga mecburuq
        public void StaticsizMetod()
        {
            Console.WriteLine("staticsiz metod");
        }
    }
}
