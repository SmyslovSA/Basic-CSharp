using System.Collections.Generic;

namespace Lecture_2_4_1
{
    public class Group
    {
        private readonly List<Student> _students = new List<Student>();

        public List<Student> Students => _students;

        public void Compare()
        {
            _students.Sort(new StudentSorter());
        }

        public void Action(GetStudents getStudents)
        {
            foreach (var student in _students)
            {
                if (getStudents(student))
                    student.IncreaseMark(1);
            }
        }

        public void StudentsAdd()
        {
            for (int i = 0; i < 10; i++)
                _students.Add(new Student());
        }
    }
}
