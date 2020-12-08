using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11._2
{
    public static class Extension
    {
        public static List<Student> FindStudents(this List<Student> students, Student.StudentPredicateDelegate studentPredicate)
        {
            List<Student> result = new List<Student>();

            foreach (var student in students)
            {
                if (studentPredicate(student))
                    result.Add(student);
            }
            return result; 
        }
    }
}
