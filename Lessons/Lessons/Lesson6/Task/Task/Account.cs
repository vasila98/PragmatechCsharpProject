using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Account
    {
        public int No;
        public string UserName;
        public string Password;


        public Account(string usname, string psw)
        {
            UserName = usname;
            Password = psw;
        }
    }
}
