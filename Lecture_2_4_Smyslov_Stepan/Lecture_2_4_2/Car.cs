using Lecture_2_4_2.Helper;

namespace Lecture_2_4_2
{
    public abstract class Car
    {
        public Car()
        {
            Brand = Rnd.RandomBrand;
            Model = Rnd.RandomModel;
            ReleasedYear = Rnd.RandomYear;
            Price = Rnd.RandomPrice;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ReleasedYear { get; set; }
        public decimal Price { get; set; }
    }
}
