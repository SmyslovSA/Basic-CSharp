using Lecture_2_4_2.Helper;

namespace Lecture_2_4_2
{
    public class FuelCar : Car
    {
        public FuelCar()
        {
            TankSize = Rnd.RandomTankSize;
        }
        public decimal TankSize { get; set; }
    }
}
