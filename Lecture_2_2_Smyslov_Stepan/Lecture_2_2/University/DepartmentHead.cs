namespace Lecture_2_2.University
{
    public class DepartmentHead : Teacher
    {
        public DepartmentHead(string name, string lastName, Facultates facultate) : base(name, lastName, facultate)
        { }

        public override bool Equals(object obj)
        {
            return obj is DepartmentHead && this.Equals((DepartmentHead)obj);
        }

        public bool Equals(DepartmentHead otherDepartmentHead)
        {
            return base.Equals(otherDepartmentHead);
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override string Work()
        {
            return $"{base.Work()} and I am head of this facultate";
        }
    }
}
