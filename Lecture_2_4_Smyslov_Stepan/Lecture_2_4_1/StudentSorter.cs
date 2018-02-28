using System.Collections.Generic;

namespace Lecture_2_4_1
{
    public class StudentSorter : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            // TODO Второй раз NullReference. Тернарный оператор / x.CompareTo(y) / x.AvgMark.CompareTo(y.AvgMart) ?
            if (x.AvgMark - y.AvgMark > 0)
                return 1;
            else if (x.AvgMark - y.AvgMark < 0)
                return -1;
            else return 0;
        }
    }
}
