using System;

namespace Lecture_2_6.StudentsClasses
{
    public class PropertyInitializationIssue : Exception
    {
        public PropertyInitializationIssue() : base() { }
        public PropertyInitializationIssue(string message) : base(message) { }
        public PropertyInitializationIssue(string message, Exception inner) : base(message, inner) { }
    }
}
