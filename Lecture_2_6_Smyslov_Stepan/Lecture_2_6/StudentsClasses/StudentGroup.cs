using System.Collections.Generic;

namespace Lecture_2_6.StudentsClasses
{
    public class StudentGroup
    {
        private readonly List<Student> _studentGroup = new List<Student>();

        public StudentGroup()
        {

        }
        public List<Student> Students => _studentGroup;

        public void AddStudent(Student student)
        {
            if (_studentGroup == null) throw new PropertyInitializationIssue();
            else if (student == null || string.IsNullOrEmpty(student.FirstName))
                throw new InvalidStudentInput();
            _studentGroup.Add(student);
        }

        public void AddStudent(params Student[] students)
        {
            var oldCount = _studentGroup.Count;
            try
            {
                foreach (var student in students)               
                    this.AddStudent(student);             
            }
            catch (InvalidStudentInput)
            {
                _studentGroup.RemoveRange(oldCount,_studentGroup.Count - 1);
                throw new InvalidStudentInput();
            }
        }
    }

}

