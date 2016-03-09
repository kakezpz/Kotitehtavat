using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student { Firstname = "Elvis", Lastname = "Virtaneen", Email = "elvis@domain.fi", Age = 20, StudentID = "K3000" };
            students[1] = new Student { Firstname = "Simo", Lastname = "Jooseppi", Email = "simo@domain.fi", Age = 19, StudentID = "K4000" };
            students[2] = new Student { Firstname = "Keijo", Lastname = "Kamala", Email = "keijo@domain.fi", Age = 22, StudentID = "K2000" };
            students[3] = new Student { Firstname = "Milla", Lastname = "Malliton", Email = "milla@domain.fi", Age = 20, StudentID = "K1000" };
            students[4] = new Student { Firstname = "Eepeli", Lastname = "Vääpeli", Email = "eepeli@domain.fi", Age = 19, StudentID = "K3333" };

            foreach (Student student in students)
            {
                Console.Write(student.ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
