namespace Lecture_2_2.University
{
    public class Student : UniversityMan
    {
        public Student(string name, string lastName, Facultates facultate):base(name,lastName,facultate)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Student && this.Equals((Student)obj);
        }

        public bool Equals(Student otherStudent)
        {
            return otherStudent.FirstName == this.FirstName
                   && otherStudent.LastName == this.LastName
                   && otherStudent.Department == this.Department;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override string Work()
        {
            return $"{base.ToString()}.I am studying at {Department} facultate";
        }
    }
}
