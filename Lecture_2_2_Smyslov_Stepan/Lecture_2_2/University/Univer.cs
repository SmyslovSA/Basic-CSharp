using System.Collections.Generic;

namespace Lecture_2_2.University
{
    public class Univer
    {
        private readonly List<Student> _students;
        private readonly List<Teacher> _teachers;
        private readonly List<DepartmentHead> _departmentHead;
        public Univer()
        {
            _students = new List<Student>();
            _teachers = new List<Teacher>();
            _departmentHead = new List<DepartmentHead>();
        }

        public List<Student> Students { get { return _students; } }
        public List<Teacher> Teachers { get { return _teachers; } }
        public List<DepartmentHead> DepartmentHeads { get { return _departmentHead; } }

        public void AddStudent(Student student)
        {
            if (student == null || _students.Contains(student)) return;
            _students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher == null || _teachers.Contains(teacher)) return;
            _teachers.Add(teacher);
        }

        public void AddDepartmentHead(DepartmentHead departmentHead)
        {
            foreach (var head in _departmentHead)
                if (head.Department == departmentHead.Department) return;
            if (departmentHead == null || _departmentHead.Contains(departmentHead)) return;
            _departmentHead.Add(departmentHead);
        }
    }
}
