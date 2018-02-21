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

        // TODO Вы не заметили что реализация этого метода слишком похожа на остальные?
        public bool Equals(DepartmentHead otherDepartmentHead)
        {
            return otherDepartmentHead.FirstName == this.FirstName
                   && otherDepartmentHead.LastName == this.LastName
                   && otherDepartmentHead.Department == this.Department;
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
