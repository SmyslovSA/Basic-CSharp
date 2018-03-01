namespace Lecture_2_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carpark = new CarPark();
            carpark.TestAdd();
            carpark.AddCarToPark(new ElectroCar());
            // TODO неиспользуемые переменные
            carpark.Cars.CarNumbers(out int eCar, out int fCar);
            var list = carpark.Cars.CarPrice(1000);
        }
    }
}
