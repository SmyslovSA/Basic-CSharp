using System.Collections.Generic;

namespace Lecture_1_9_2.Marks
{
    public class StudentGroup
    {
        private readonly List<Student> _group;

        public StudentGroup()
        {
            _group = new List<Student>();
        }

        public Student this[int i]
        {
            get { return IndexIsInRange(i) ? _group[i] : null; }
            set
            {
                if (!IndexIsInRange(i) || value == null) return;
                _group[i] = value;
            }
        }

        public bool IndexIsInRange(int index)
        {
            return index >= 0 && index < _group.Count;
        }

        public void AddStudent(Student student)
        {
            if (student == null) return;
            _group.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _group.Remove(student);
        }

        public List<Student> Group()
        {
            return _group;
        }
    }
}
