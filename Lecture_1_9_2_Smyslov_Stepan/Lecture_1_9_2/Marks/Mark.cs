using System;

namespace Lecture_1_9_2.Marks
{
    public struct Mark : IComparable<Mark>
    {
        public Mark(string name, DateTime dateTime,int number)
        {
            LectureName = name;
            Date = dateTime;
            MarkNumber = number;
        }

        public string LectureName {get;}
        public DateTime Date {get;}
        public int MarkNumber {get;}

        public int CompareTo(Mark other)
        {
            return MarkNumber - other.MarkNumber;
        }
    }
}
