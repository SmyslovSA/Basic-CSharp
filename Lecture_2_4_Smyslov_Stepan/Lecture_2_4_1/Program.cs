namespace Lecture_2_4_1
{
    public delegate bool GetStudents(Student student);
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new Group();
            group.StudentsAdd();
            GetStudents studentsGroup = student => student.AvgMark > 4 && student.AvgMark < 6;
            group.Action(studentsGroup);
            group.Compare();
        }
    }
}
