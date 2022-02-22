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
            Account[] array = new Account[2];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Username:");
                string username = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();

                Account accnt = new Account(username, password);
                accnt.No = i;
                array[i] = accnt;
            }
        }
    }
}
