namespace Lecture_2_2.University
{
    public class Student : UniversityMan
    {
        public Student(string name, string lastName, Facultates facultate) :base(name, lastName, facultate)
        {
        }

        public override string Work()
        {
            return $"{base.ToString()}.I am studying at {Department} facultate";
        }
    }
}
