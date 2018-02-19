using System.Collections.Generic;
using System.Linq;

namespace Lecture_2_1.University
{
    public class Univer
    {
        private readonly List<Human> _peoples;
        private readonly List<Lection> _lections;

        public List<Lection> GetLections { get;}
        public List<Human> GetHumans { get;}

        public Univer()
        {
            _peoples = new List<Human>();
            _lections = new List<Lection>();
        }

        public void AddHuman(Human human)
        {
            if (human != null) _peoples.Add(human);
        }

        public int CountHuman()
        {
            return _peoples.Count;
        }

        public void AddLection(Lection lection)
        {
            if (lection != null) _lections.Add(lection);
        }

        public int CountLections()
        {
            return _lections.Count();
        }
    }
}
