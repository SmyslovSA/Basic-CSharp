namespace Lecture_2_1.University
{
    public class StudentSpecialist : Student
    {
        public StudentSpecialist(string name, string lastName, LectionsTypes lections) : base(name, lastName)
        {
            StudentType = lections;
        }

        public LectionsTypes StudentType { get; set; }

        public override string Learn(LectionsTypes lection)
        {
            return $"{base.Learn(lection)} {(StudentType == lection ? "is studying" : "is sleeping")}";
        }
    }
}