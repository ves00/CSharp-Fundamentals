using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace _04.Students
{
    internal class Program
    {
        static void Main()
        {
            //Array of objects from class Student
            //Student[] studentsArr = new Student[5];
            //Array of random objects with random properties
            //object[] objArr = new object[5];
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                double grade = double.Parse(cmdArgs[2]);

                Student currStudent = new Student(firstName, lastName, grade);
                students.Add(currStudent);
            }

            List<Student> orderedStudents = students
                .OrderByDescending(s => s.Grade) //Sorting the students by grade in descending order
                .ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade) //string firstName, string lastName, double grade - parameters
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}
