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
        public string GroupNumber;
        public int Age;

        public  Student(string fullname, string groupno, int age)
        {
            Name = fullname;
            GroupNumber = groupno;
            Age = age;
           
            
        }

        public void GetBirthYear(Student student)
        {
            int year = DateTime.Now.Year - student.Age;
            Console.WriteLine(year);
        }
    }
}
