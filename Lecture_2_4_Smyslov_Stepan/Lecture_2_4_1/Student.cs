using System;
using Lecture_2_4_1.Helper;

namespace Lecture_2_4_1
{
    public class Student : IComparable<Student>
    {
        public Student()
        {
            FirstName = Rnd.RandomFirstName;
            LastName = Rnd.RandomLastName;
            AvgMark = Rnd.RandomMark;
        }

        public Student(int avgMark, string lastName, string firstName)
        {
            AvgMark = avgMark;
            LastName = lastName;
            FirstName = firstName;
        }

        public double AvgMark { get; private set; }

        public string LastName { get; }

        public string FirstName { get; }

        public void IncreaseMark(int changer)
        {
            if (AvgMark + changer < 9 && AvgMark - changer > 0)
                AvgMark += changer;
        }

        public int CompareTo(Student other)
        {
            return this.AvgMark.CompareTo(other.AvgMark);
        }
    }
}
