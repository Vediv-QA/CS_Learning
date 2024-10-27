using System.Reflection;

namespace CS_Learning_8
{
    class Chicken
    {
        public int Number { get; private set; }
        public int Weight { get; private set; }
        public string? Color { get; private set; } = "undifened";
        public Chicken(int number, int weight)
        {
            Number = number;
            Weight = weight;
        }
        public Chicken(int number, int weight, string color)
        {
            Number = number;
            Weight = weight;
            Color = color;
        }
    }
}
