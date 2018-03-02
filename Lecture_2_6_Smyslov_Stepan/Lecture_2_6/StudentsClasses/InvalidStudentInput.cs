using System;

namespace Lecture_2_6.StudentsClasses
{
    public class InvalidStudentInput: Exception
    {
        public InvalidStudentInput() : base() { }
        public InvalidStudentInput(string message) : base(message) { }
        public InvalidStudentInput(string message, Exception inner) : base(message, inner) { }
    }
}
