using System.Collections.Generic;
using System.Linq;

namespace Lecture_2_1.University
{
    public class Univer
    {
        private readonly List<Human> _peoples;
        private readonly List<Lection> _lections;

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
            // TODO Вызвали вместо свойства метод зачемто
            return _peoples.Count();
        }

        public void AddLection(Lection lection)
        {
            if (lection != null) _lections.Add(lection);
        }

        public int CountLections()
        {
            return _lections.Count();
        }

        // TODO Readonly свойство наверное напрашивается?
        public List<Lection> GetLections()
        {
            return _lections;
        }

        public List<Human> GetHumans()
        {
            return _peoples;
        }

        // TODO Лучше в отдельный класс
        public void GetStartParameters()
        {
            var math = new Lection("Mathemathic", LectionsTypes.Technical);
            var history = new Lection("History", LectionsTypes.Humanitarian);
            var chorus = new Lection("Chorus", LectionsTypes.Musical);
            _lections.Add(math);
            _lections.Add(history);
            _lections.Add(chorus);
            _peoples.Add(new StudentTech("Vasiliy", "Ivanov"));
            _peoples.Add(new StudentTech("Oleg", "Petrov"));
            _peoples.Add(new StudentHumanist("Olga", "Sokolova"));
            _peoples.Add(new StudentHumanist("Andrey", "Sidorov"));
            _peoples.Add(new Teacher("Viktor", "Petrovich", math));
            _peoples.Add(new Teacher("Irina", "Voronova", history));
            _peoples.Add(new Teacher("Tatyana", "Semenova", chorus));
        }
    }
}
