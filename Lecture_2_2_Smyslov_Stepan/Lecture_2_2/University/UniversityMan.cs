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
    }
}
