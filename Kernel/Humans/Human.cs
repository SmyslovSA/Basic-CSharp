using IHumans;

namespace Humans
{
    public class Human : IHuman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human()
        {
            FirstName = "John";
            LastName = "Dough";
        }
    }
}

