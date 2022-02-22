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
            Account a = new Account("vesi", "vesi1236", "vesi@gmail.com");
            a.ShowInfo();
            a.PasswordChecker("vesi1256");
        }
    }
    class Account: User
    {
        public Account (string nm, string psw, string mail): base(nm, psw, mail)
        {

        }
        public override void PasswordChecker(string password)
        {
            if (this.Password.Length >= 8)
            {
                Console.WriteLine("duzgundur");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("ad:"+Name+" "+"email:"+" "+Email);
        }


    }
    abstract class User
    {
        public string Name;
        public string Password;
        public string Email;

        public User(string name,string psw, string email)
        {
            Name = name;
            Password = psw;
            Email = email;
        }
        public abstract void PasswordChecker(string password);
        public virtual void ShowInfo()
        {
            Console.WriteLine("ad:" + Name + " " + "email:" + " " + Email);
        }
    }

}
