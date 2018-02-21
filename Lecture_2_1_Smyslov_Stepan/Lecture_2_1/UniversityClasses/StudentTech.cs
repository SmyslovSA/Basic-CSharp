namespace Lecture_2_1.University
{
    public class StudentTech : StudentSpecialist
    {
        public StudentTech(string name, string lastName) : base(name, lastName, LectionsTypes.Technical)
        {
        }

        // TODO Вы где нибудь этим пользуетесь?
        public LectionsTypes Specialization { get; set; }
    }
}