namespace Lecture_2_1.University
{
    public class StudentHumanist : Student
    {
        const LectionsTypes specialization = LectionsTypes.Humanitarian;
        public StudentHumanist(string name, string lastName) : base(name, lastName) { }

        public override string Learn(LectionsTypes lection)
        {
            return $"{base.Learn(lection)} is {(lection == specialization ? "studying" : "sleeping")}";
        }
    }
}

