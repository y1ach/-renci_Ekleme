using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Program program = new Program();
                program.AddStudent();
                Console.ReadLine();

            }


        }
        static List<string> Students = new List<string>();
        public void AddStudent()
        {
            Student student = new Student();

            Console.WriteLine("ID: ");
            student.Id = Console.ReadLine();

            Console.WriteLine("Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Class: ");
            student.Class = Console.ReadLine();

            Students.Add($"ID: {student.Id}, Name: {student.Name}, Class: {student.Class}");

            Console.WriteLine("Student added successfully.");

            // Tüm öğrenci bilgilerini ekrana yazdırma
            foreach (var s in Students)
            {
                Console.WriteLine(s);
            }

        }
    }
}
