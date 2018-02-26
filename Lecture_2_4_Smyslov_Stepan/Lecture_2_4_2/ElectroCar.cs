using Lecture_2_4_2.Helper;

namespace Lecture_2_4_2
{
    public class ElectroCar : Car
    {
        public ElectroCar()
        {
            BatterySize = Rnd.RandomBatterySize;
        }
        public decimal BatterySize { get; set; }
    }
}
