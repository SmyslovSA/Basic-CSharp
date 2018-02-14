namespace Lecture_1_9.PredictionClasses
{
    public struct Prediction
    {
        public string Name { get; set; }
        public Time InTime { get; set; }

        public Prediction(string name,Time time)
        {
            Name = name;
            InTime = time;
        }

        public override string ToString()
        {
            return $"{InTime} предсказание такое: {Name}";
        }
    }
}
