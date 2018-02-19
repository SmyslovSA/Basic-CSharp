namespace Lecture_2_1.University
{
    public class Teacher : Human
    {
        public Teacher(string name, string lastName, Lection lection) : base(name, lastName)
        {
            Specialization = lection.LectureName;
        }

        public string Specialization { get; set;}

        public virtual string Work()
        {
           return $"{base.ToString()} Teacher of {Specialization}";
        }
    }
}
