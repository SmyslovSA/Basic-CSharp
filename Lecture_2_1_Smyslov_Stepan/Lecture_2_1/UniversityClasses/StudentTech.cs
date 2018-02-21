namespace Lecture_2_1.University
{
    public class StudentTech : StudentSpecialist
    {
        public StudentTech(string name, string lastName) : base(name, lastName,LectionsTypes.Technical)
        {
        }

        public LectionsTypes Specialization { get; set; }
    }
}