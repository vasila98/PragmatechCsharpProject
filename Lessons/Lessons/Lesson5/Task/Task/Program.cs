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
            Student[] students = new Student[5];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Adinizi daxil edin: ");
                string ad=Console.ReadLine();

                Console.WriteLine("Qrup nomresini daxil edin: ");
                string qrup=Console.ReadLine();

                Console.WriteLine("Yasinizi daxil edin: ");
                int yas =Convert.ToInt32(Console.ReadLine());

                Student stud=new Student(ad,qrup,yas);
                stud.GetBirthYear(stud);

                students[i] = stud;
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + " " + student.GroupNumber + " " + student.Age + " ");
            }
        }
    }
}
