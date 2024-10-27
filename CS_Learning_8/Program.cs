using System;
using System.Collections.Generic;

namespace CS_Learning_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите кол-во омлетов, которые необходимо будет приготовить ресторану для банкета: ");
            var input_omelette = Console.ReadLine();
            if (Int32.TryParse(input_omelette, out int omelette))
            {
                if (omelette <= 0)
                {
                    Console.WriteLine("Число омлетов не может быть отрицательным или 0 !!!");
                }
            }
            else
            {
                Console.WriteLine("\nНеобходимо ввести целове число !!!");
            }
            Console.WriteLine($"Яиц на {omelette} омлетов, несет в день кол-во куриц - {omelette / 2}\nМолока на {omelette} омлетов," +
                $" дает в день кол-во коров - {omelette / 4}\nЗадействуем на ферме cоотсветсвующее кол-во коров и куриц!");
            Console.WriteLine("\nДанные фермы: ");
            Farm farm = new Farm("Тургоякское шоссе, 55");
            farm.Print();
            int count_chick = 0;
            int num_chick = 1;
            int count_cow = 0;
            int num_cow = 1;
            while (count_chick <= (omelette / 2 - 1))
            {
                farm.AddChicken(new Chicken(num_chick, 5));
                count_chick++;
                num_chick++;
            }
            while (count_cow <= (omelette / 4 - 1))
            {
                farm.AddCow(new Cow(num_cow, 100));
                count_cow++;
                num_cow++;
            }
            Console.WriteLine("\nСписок задействованых животных c фермы: ");
            farm.Info();
            Console.WriteLine($"\nИнгридиенты для {omelette} омлетов будут готовы к утру!"); 
        }
    }
}

