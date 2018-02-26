using System;
using System.Collections.Generic;

namespace Lecture_2_4_2
{
    public static class ExtendedClass
    {
        public static void CarNumbers(this List<Car> cars, out int eCar, out int fCar)
        {
            eCar = fCar = 0;
            foreach (var car in cars)
            {
                if (car is ElectroCar) eCar++;
                else if (car is FuelCar) fCar++;
            }
        }

        public static List<Car> CarPrice(this List<Car> cars, int startPrice = 0, int maxPrice = 0)
        {
            var newCars = new List<Car>();
            if (maxPrice == 0)
            {
                foreach (var car in cars)
                {
                    if (car.Price > startPrice)
                        newCars.Add(car);
                }
                return newCars;
            }
            else foreach (var car in cars)
                {
                    if (car.Price > startPrice && car.Price < maxPrice)
                        newCars.Add(car);
                }
            return newCars;
        }

        public static void AddCar(this Car car)
        {
            Console.WriteLine($"{car.Brand} {car.Model} was added to the park. It costs {car.Price} $.");
        }
    }
}
