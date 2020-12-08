using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11._2
{
    public class Student
    {
        public delegate bool StudentPredicateDelegate(Student student);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool Adult(Student student) => student.Age >= 18;
        public static bool CheckFirstName(Student student) => student.FirstName?[0] == 'A';
        public static bool CheckLastName(Student student) => student.LastName?.Length > 3;
    }
}
