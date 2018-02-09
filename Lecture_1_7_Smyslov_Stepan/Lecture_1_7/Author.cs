using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7
{
    class Author
    {
        public string Name;
        public string LastName;
        public uint DoB;
        public readonly List<Author> list = new List<Author>();
    }
}
