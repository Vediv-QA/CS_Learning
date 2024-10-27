namespace CS_Learning_8
{
    class Cow
    {
        public int Number { get; private set; }
        public int Weight { get; private set; }
        public string? Breed { get; private set; } = "undifened";
        public Cow(int number, int weight)
        {
            Number = number;
            Weight = weight;
        }
        public Cow(int number, int weight, string breed)
        {
            Number = number;
            Weight = weight;
            Breed = breed;
        }
    }
}
