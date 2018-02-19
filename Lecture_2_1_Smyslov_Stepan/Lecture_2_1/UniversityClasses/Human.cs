namespace Lecture_2_1.University
{
    public class Human
    {
        public Human():this("John","Dough") { }

        public Human(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }

        public string FirstName {get; set;}
        public string LastName {get; set;}

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
