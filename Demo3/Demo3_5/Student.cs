using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_5
{
    class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string StudentID { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return "Student:\n-Firstname: " + Firstname + "\n-Lastname: " + Lastname + "\n-Age: " + Age + "\n-StudentID: " + StudentID + "\n-Email: " + Email;
        }
    }

}
