namespace Lecture_2_1.University
{
    public class StudentTech : Student
    {
        // TODO Константы с большой =)
        const LectionsTypes specialization = LectionsTypes.Technical;
        public StudentTech(string name, string lastName) : base(name, lastName) { }

        public override string Learn(LectionsTypes lection)
        {
            return $"{base.Learn(lection)} is {(lection == specialization ? "studying" : "sleeping")}";
        }
    }
}