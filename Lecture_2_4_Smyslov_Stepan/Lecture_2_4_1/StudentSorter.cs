using System.Collections.Generic;

namespace Lecture_2_4_1
{
    public class StudentSorter : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.AvgMark - y.AvgMark > 0)
                return 1;
            else if (x.AvgMark - y.AvgMark < 0)
                return -1;
            else return 0;
        }
    }
}
