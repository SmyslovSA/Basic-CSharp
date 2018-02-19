namespace Lecture_2_1.University
{
    public class StudentHumanist : Student
    {
        // TODO Я вижу дублирование кода. А вы? =)
        const LectionsTypes Specialization = LectionsTypes.Humanitarian;
        public StudentHumanist(string name, string lastName) : base(name, lastName) { }

        public override string Learn(LectionsTypes lection)
        {
            return $"{base.Learn(lection)} is {(lection == Specialization ? "studying" : "sleeping")}";
        }
    }
}

