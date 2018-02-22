namespace Lecture_2_2.University
{
    public abstract class UniversityMan: HomoSapiens
    {
        protected UniversityMan(string name, string lastName, Facultates facultate)
        {
            FirstName = name;
            LastName = lastName;
            Department = facultate;
        }

        public Facultates Department { get; set; }

        public abstract string Work();

        public override bool Equals(object obj)
        {
            return obj is UniversityMan && this.Equals((UniversityMan)obj);
        }

        public bool Equals(UniversityMan universityMan)
        {
            return universityMan.FirstName == this.FirstName
                   && universityMan.LastName == this.LastName
                   && universityMan.Department == this.Department;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
