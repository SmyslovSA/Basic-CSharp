namespace Lecture_2_2.University
{
    public class Teacher : UniversityMan
    {
        public Teacher(string name, string lastName, Facultates facultate) : base(name, lastName, facultate)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher && this.Equals((Teacher)obj);
        }

        public bool Equals(Teacher otherTeacher)
        {
            return otherTeacher.FirstName == this.FirstName
                   && otherTeacher.LastName == this.LastName
                   && otherTeacher.Department == this.Department;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override string Work()
        {
            return $"{base.ToString()}.I am teaching at {Department} facultate";
        }
    }
}
