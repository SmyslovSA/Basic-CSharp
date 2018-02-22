namespace Lecture_2_2.University
{
    public class Teacher : UniversityMan
    {
        public Teacher(string name, string lastName, Facultates facultate) : base(name, lastName, facultate)
        {
        }

        public override string Work()
        {
            return $"{base.ToString()}.I am teaching at {Department} facultate";
        }
    }
}
