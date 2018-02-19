using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture_1_9_2.Marks
{
    public class Student
    {
        private readonly List<Mark> _marks = new List<Mark>();

        public Student(string name, string lastName, DateTime dateTime)
        {
            FirstName = name;
            LastName = lastName;
            DoB = dateTime;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        public void AddMark(Mark mark)
        {
            if (mark.MarkNumber <= 0 || mark.MarkNumber > 10) return;
            _marks.Add(mark);
        }

        public override string ToString()
        {
            return
                $"{FirstName} {LastName}. Marks: Max:{this.GetMaxMark()}, Min:{this.GetMinMark()}, Average:{this.GetAverageMark():#.##}";
        }

        public override bool Equals(object obj)
        {
            return obj is Student && this.Equals((Student) obj);
        }

        public bool Equals(Student otherStudent)
        {
            return otherStudent.FirstName == this.FirstName
                   && otherStudent.LastName == this.LastName
                   && otherStudent.DoB == this.DoB;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public int GetMaxMark()
        {
            return _marks.Max().MarkNumber;
        }

        public int GetMinMark()
        {
            return _marks.Min().MarkNumber;
        }

        public double GetAverageMark()
        {
            double sum = 0;
            foreach (var mark in _marks)
            {
                sum += mark.MarkNumber;
            }
            return sum / _marks.Count;
        }
    }
}