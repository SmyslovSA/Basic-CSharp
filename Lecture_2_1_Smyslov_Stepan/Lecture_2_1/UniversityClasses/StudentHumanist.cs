namespace Lecture_2_1.University
{
    public class StudentHumanist : StudentSpecialist
    {
        public StudentHumanist(string name, string lastName) : base(name, lastName, LectionsTypes.Humanitarian)
        {
        }
    }
}