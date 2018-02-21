using System.Collections.Generic;

namespace Lecture_2_2.University
{
    public class Univer
    {
        public Univer()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            DepartmentHeads = new List<DepartmentHead>();
        }

        public List<Student> Students { get; }
        public List<Teacher> Teachers { get; }
        public List<DepartmentHead> DepartmentHeads {get;}

        public void AddStudent(Student student)
        {
            if (student == null || Students.Contains(student)) return;
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher == null || Teachers.Contains(teacher)) return;
            Teachers.Add(teacher);
        }

        public void AddDepartmentHead(DepartmentHead departmentHead)
        {
            foreach (var head in DepartmentHeads)
                if (head.Department == departmentHead.Department) return;
            if (departmentHead == null || DepartmentHeads.Contains(departmentHead)) return;
            DepartmentHeads.Add(departmentHead);
        }
    }
}
