﻿using System;
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
            Student student = new Student("Vesi", "Hesenova");
            Console.WriteLine(student.Name);
            student.GetFullName("vesi", "hesenova");
           
        }
    }
}
