namespace Lecture_2_1.University
{
    public class Student : Human
    {
        public Student(string name, string lastName) : base(name, lastName) { }

        public virtual string Learn(LectionsTypes lection)
        {
            return $"{base.ToString()} student";
        }
    }
}
