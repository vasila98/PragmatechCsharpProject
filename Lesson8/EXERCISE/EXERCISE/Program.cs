using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] array= new Student[1];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("adi daxil ele");
                string name=Console.ReadLine();
                Console.WriteLine( "bali daxil ele" );
                int bal=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("yasi daxil ele");
                int yas=Convert.ToInt32(Console.ReadLine());
                Student obyekt = new Student(name, bal, yas);
                obyekt.GetBirthYear(obyekt);
                array[i] = obyekt;
                
            }
            Student.GetFullName(array[0].Name);
            

        }
    }
}
