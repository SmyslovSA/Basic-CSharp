namespace Lecture_2_4_1
{
    public delegate bool GetStudents(Student student);
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new Group();
            group.StudentsAdd(); 
            group.Action(student => student.AvgMark > 4 && student.AvgMark < 6);
            group.Compare();
        }
    }
}
