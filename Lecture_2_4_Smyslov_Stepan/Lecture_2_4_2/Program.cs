using System;

namespace Lecture_2_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carpark = new CarPark();
            carpark.TestAdd();
            carpark.AddCarToPark(new ElectroCar());
            carpark.Cars.CarCount(out int eCar, out int fCar);
            var list = carpark.Cars.CarPrice(1000);
            // TODO перенести cw в другое место
            Console.WriteLine($"In park {eCar} electo cars and {fCar} fuel cars");
        }
    }
}
