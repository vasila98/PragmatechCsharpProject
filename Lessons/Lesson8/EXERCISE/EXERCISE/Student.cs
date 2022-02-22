using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE
{
    internal class Student
    {
        public string Name;
        public int Bal;
        public int Age;

        public Student(string nm, int bl, int yas)
        {
            Name = nm;  
            Bal = bl;
            Age = yas;
        }

        public static void GetFullName(string name)
        {
            Console.WriteLine(name);
        }

        public   void GetBirthYear( Student student)
        {
            int il=DateTime.Now.Year-student.Age;
            Console.WriteLine(il); 
        }
    }
}
