using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Student
    {
        public string Name;
        public string Surname;


        public Student(string usrname, string surnm)
        {
            Name= usrname;
            Surname= surnm;
        }

        public  void GetFullName( string ad, string soyad)
        {
            Console.WriteLine(ad + soyad); 

        }

        public static  string AdSoyad(string name, string surname)
        {

            name = "Vesi";
            surname = "Hesenova";

            return name + " " + surname;
        }
    }
}
