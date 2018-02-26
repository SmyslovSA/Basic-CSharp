using System;
using RandomNameGeneratorLibrary;

namespace Lecture_2_4_1.Helper
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

            public static string RandomFirstName => NameGenerator.GenerateRandomFirstName();
            public static string RandomLastName => NameGenerator.GenerateRandomLastName();
            public static double RandomMark => Rand.Next(0, 9) + Rand.NextDouble();
        }
}
