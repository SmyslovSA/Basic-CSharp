using System.Collections.Generic;

namespace Lecture_2_2.University
{
    public class Univer
    {
        private readonly List<Student> _students;
        private readonly List<Teacher> _teachers;
        private readonly List<DepartmentHead> _departmentHeads;

        public Univer()
        {
            _students = new List<Student>();
            _teachers = new List<Teacher>();
            _departmentHeads = new List<DepartmentHead>();
        }

        public List<Student> Students { get { return _students;}}
        public List<Teacher> Teachers { get { return _teachers;}}
        public List<DepartmentHead> DepartmentHeads {get {return _departmentHeads;}}

        public void AddStudent(Student student)
        {
            if (student == null || _students.Contains(student)) return;
            _students.Add(student);
        }

        public int StudentsCount()
        {
            return _students.Count;
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher == null || _teachers.Contains(teacher)) return;
            _teachers.Add(teacher);
        }

        public int TeachersCount()
        {
            return _teachers.Count;
        }

        public void AddDepartmentHead(DepartmentHead departmentHead)
        {
            foreach (var head in _departmentHeads)
                if (head.Department == departmentHead.Department) return;
            if (departmentHead == null || _departmentHeads.Contains(departmentHead)) return;
            _departmentHeads.Add(departmentHead);
        }

        public int DepartmentHeadsCount()
        {
            return _departmentHeads.Count;
        }
    }
}
