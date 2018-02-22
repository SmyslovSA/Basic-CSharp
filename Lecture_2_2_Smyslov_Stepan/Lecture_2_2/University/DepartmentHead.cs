namespace Lecture_2_2.University
{
    public class DepartmentHead : Teacher
    {
        public DepartmentHead(string name, string lastName, Facultates facultate) : base(name, lastName, facultate)
        { }

        public override string Work()
        {
            return $"{base.Work()} and I am head of this facultate";
        }
    }
}
