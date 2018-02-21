using System.Collections.Generic;
using System.Linq;

namespace Lecture_2_1.University
{
    public class Univer
    {
        public List<Lection> GetLections { get; }
        public List<Human> GetHumans { get; }
        public int CountHuman { get; }
        public int CountLections { get; }
        
        public Univer()
        {
            GetHumans = new List<Human>();
            GetLections = new List<Lection>();
        }

        public void AddHuman(Human human)
        {
            if (human != null) GetHumans.Add(human);
        }

        public void AddLection(Lection lection)
        {
            if (lection != null) GetLections.Add(lection);
        }
    }
}