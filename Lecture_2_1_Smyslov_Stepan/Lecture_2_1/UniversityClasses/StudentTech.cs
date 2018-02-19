namespace Lecture_2_1.University
{
    public class StudentTech : Student
    {
        const LectionsTypes Specialization = LectionsTypes.Technical;
        public StudentTech(string name, string lastName) : base(name, lastName) { }

        public override string Learn(LectionsTypes lection)
        {
            return $"{base.Learn(lection)} is {(lection == Specialization ? "studying" : "sleeping")}";
        }
    }
}