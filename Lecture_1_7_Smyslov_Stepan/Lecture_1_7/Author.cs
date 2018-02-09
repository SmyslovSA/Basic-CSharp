using System.Collections.Generic;

namespace Lecture_1_7
{
    class Author
    {
        public string Name;
        public string LastName;
        public uint DoB;
        // TODO что-то вас именно лист за смущал
        // TODO ну и зачем автору список авторов? Он в принципе не должен знать о других =)
        public readonly List<Author> list = new List<Author>();
    }
}
