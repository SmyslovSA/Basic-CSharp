using System;
using RandomNameGeneratorLibrary;

namespace Lecture_2_4_2.Helper
{
    public static class Rnd
    {
        private static readonly PersonNameGenerator NameGenerator;
        private static readonly Random Rand;

        static Rnd()
        {
            Rand = new Random(DateTime.Now.Second);
            NameGenerator = new PersonNameGenerator(Rand);
        }

        public static string RandomBrand => NameGenerator.GenerateRandomFirstName();
        public static string RandomModel => NameGenerator.GenerateRandomLastName();
        public static int RandomYear => Rand.Next(0, 2000);
        public static int RandomPrice => Rand.Next(0, 2000);
        public static decimal RandomTankSize => Rand.Next(0, 2000);
        public static decimal RandomBatterySize => Rand.Next(0, 2000);        
    }
}
