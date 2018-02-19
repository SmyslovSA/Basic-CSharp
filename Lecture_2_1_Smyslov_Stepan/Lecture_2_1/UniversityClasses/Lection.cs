namespace Lecture_2_1.University
{
    public class Lection
    {
        public Lection(string name, LectionsTypes lectionsTypes)
        {
            LectureName = name;
            LectureType = lectionsTypes;
        }

        public string LectureName {get; set;}
        public LectionsTypes LectureType {get; set;}
    }
}
