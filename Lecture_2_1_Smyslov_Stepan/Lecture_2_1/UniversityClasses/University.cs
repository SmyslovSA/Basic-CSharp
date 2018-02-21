using System.Collections.Generic;
using System.Linq;

namespace Lecture_2_1.University
{
    public class Univer
    {
        private readonly List<Human> _peoples;
        private readonly List<Lection> _lections;

        // TODO Можно заменить на Readonly свойство 
        // public List<Lection> GetLections { get; }
        public List<Lection> GetLections
        {
            get { return _lections; }
        }

        public List<Human> GetHumans
        {
            get { return _peoples; }
        }

        public Univer()
        {
            _peoples = new List<Human>();
            _lections = new List<Lection>();
        }

        public void AddHuman(Human human)
        {
            if (human != null) _peoples.Add(human);
        }

        // TODO Удобнее было бы использовать свойство
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
            return _lections.Count;
        }
    }
}