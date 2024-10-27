namespace CS_Learning_8
{
    class Farm
    {
        public int number = 1;              // Номер фермы
        public string adress;              //  Адрес фермы
        public List<Chicken> Chickens;    //   Курицы на ферме
        public List<Cow> Cows;           //    Коровы на ферме
        public Farm(int n, string a)
        {
            number = n;
            adress = a;
            Chickens = new List<Chicken>();
            Cows = new List<Cow>();
        }

        public Farm(string a)
        {
            adress = a;
            Chickens = new List<Chicken>();
            Cows = new List<Cow>();
        }

        public void Print()
        {
            Console.WriteLine($"Номер фермы: {number}\nАдрес фермы: {adress}");
        }

        public void AddChicken(Chicken chicken)
        {
            Chickens.Add(chicken);
        }
        public void AddCow(Cow cow)
        {
            Cows.Add(cow);
        }

        public void Info()
        {
            foreach (var chicken in Chickens)
            {
                Console.WriteLine(chicken);
            }
            foreach (var cow in Cows)
            {
                Console.WriteLine(cow);
            }
        }
    }

}

