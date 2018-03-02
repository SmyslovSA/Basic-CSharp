using System;
using Lecture_2_6.StudentsClasses;

namespace Lecture_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new StudentGroup();
            var newStudent = new Student() { FirstName = "Alex", LastName = "Fletcher" };
            var newStudent2 = new Student();
            var newStudent3 = new Student() { FirstName = "Sam", LastName = "Fisher" };

            try
            {
                group.AddStudent(newStudent);
                group.AddStudent(newStudent,newStudent2,newStudent3);
            }
            catch (PropertyInitializationIssue)
            {
                Console.WriteLine("List isn't initialized");
            }
            catch (InvalidStudentInput)
            {
                Console.WriteLine("Student(s) wasn't added");
            }
        }
    }
}
