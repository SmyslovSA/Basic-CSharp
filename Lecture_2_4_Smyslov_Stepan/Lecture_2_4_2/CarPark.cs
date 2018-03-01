using System.Collections.Generic;

namespace Lecture_2_4_2
{
    public class CarPark
    {
        private readonly List<Car> _cars;
        public CarPark()
        {
            _cars = new List<Car>();
        }

        public List<Car> Cars => _cars;

        public void AddCarToPark(Car car)
        {
            if (car == null) return;
            _cars.Add(car);
            car.AddCar();
        }

        public void TestAdd()
        {
            for (int i = 0; i < 10; i++)
            {
                _cars.Add(new ElectroCar());
                _cars.Add(new FuelCar());
            }
        }
    }
}
