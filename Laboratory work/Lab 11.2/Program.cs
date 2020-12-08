using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_11._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numberOfSrudent = 10;
            List<Student> students = new List<Student>();
            List<Student> studentsTemp = new List<Student>();
            Random random = new Random();
            //Задание 7
            for (int i = 0; i < numberOfSrudent; i++)
            {
                Student student = new Student();
                student.FirstName = GenerateFirstName(random);
                student.LastName = GenerateLastName(random);
                student.Age = random.Next(10, 30);
                students.Add(student);
                Thread.Sleep(100);
            }

            
            Console.WriteLine($"Список из {numberOfSrudent} студентов:\n");
            foreach (var student in students)
                Console.WriteLine(student);

            Console.WriteLine("Если список пуст, значит таких студентов нету.");

            //Задание 8

            Console.WriteLine("\nСтуденты старше 18:\n");
            studentsTemp = students.FindStudents(Student.Adult);
            foreach (var student in studentsTemp)
                Console.WriteLine(student);

            Console.WriteLine("\nСтуденты имя которых начинаеться на \'A\':\n");
            studentsTemp = students.FindStudents(Student.CheckFirstName);
            foreach (var student in studentsTemp)
                Console.WriteLine(student);

            Console.WriteLine("\nСтуденты фамилия которых больше 3 символов:\n");
            studentsTemp = students.FindStudents(Student.CheckLastName);
            foreach (var student in studentsTemp)
                Console.WriteLine(student);

            //Задание 9

            Console.WriteLine("\nСтуденты старше 18:\n");
            studentsTemp = students.FindStudents(s => s.Age >= 18);
            foreach (var student in studentsTemp)
                Console.WriteLine(student);
            Console.WriteLine();
            
            Console.WriteLine("\nСтуденты имя которых начинаеться на \'A\':\n");
            studentsTemp = students.FindStudents(s => s.FirstName?[0] == 'A');
            foreach (var student in studentsTemp)
                Console.WriteLine(student);
            Console.WriteLine();

            Console.WriteLine("\nСтуденты фамилия которых больше 3 символов:\n");
            studentsTemp = students.FindStudents(s => s.LastName?.Length > 3);
            foreach (var student in studentsTemp)
                Console.WriteLine(student);
            Console.WriteLine();

            //Задание 10

            Console.WriteLine("\nСтуденты от 20 до 25 лет:\n");
            studentsTemp = students.FindStudents(s => s.Age >= 20 && s.Age <= 25);
            foreach (var student in studentsTemp)
                Console.WriteLine(student);
            Console.WriteLine();

            //Задание 11

            Console.WriteLine("\nСтуденты с именем Andrew:\n");
            studentsTemp = students.FindStudents(s => s.FirstName.Equals("Andrew"));
            foreach (var student in studentsTemp)
                Console.WriteLine(student);
            Console.WriteLine();

            //Задание 12

            Console.WriteLine("\nСтуденты с фамилией Troelsen:\n");
            studentsTemp = students.FindStudents(s => s.LastName.Equals("Troelsen"));
            foreach (var student in studentsTemp)
                Console.WriteLine(student);
            Console.WriteLine();

            Console.ReadKey();

        }

        public static string GenerateFirstName(Random random)
        {
            string[] FirstName = new string[]
            {
                "Max",
                "Scott",
                "Jax",
                "Taylor",
                "Harrison",
                "Arthur",
                "Andrew",
                "Bill",
                "Lewis"
            };
            return FirstName[random.Next(FirstName.Length)];
        }
        public static string GenerateLastName(Random random)
        {
            string[] LastName = new string[]
               {
                "Duran",
                "Ortiz",
                "Gardner",
                "Pacheco",
                "Fedorenko",
                "Simmons",
                "Goodwin",
                "Watkins",
                "Troelsen"
               };
            return LastName[random.Next(LastName.Length)];
        }
    }
}
