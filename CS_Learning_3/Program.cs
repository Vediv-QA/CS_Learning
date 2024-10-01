try
{
        int size = 10;
        var num_1 = new string[size];
        int i = 0;
        int err = 0;
        while (i < num_1.Length)
        {
            Console.Write("Введите число: ");
            num_1[i] = Console.ReadLine();
            if (num_1[i] == "Q") // Условия стоп-символа
            {
                Console.WriteLine("");
                Console.WriteLine("Был указан стоп-символ, введите порядковый номер необходимого действия: ");
                Console.WriteLine("1 - Продолжить");
                Console.WriteLine("2 - Очистить");
                Console.WriteLine("3 - Выйти ");
                Console.WriteLine("");
                Console.Write("Номер: ");
                string? choice = Console.ReadLine();
                if (choice == "1")
                {
                    continue;
                }
                else if (choice == "2")
                {
                    var num_3 = new string[size];
                    for (int f = 0; f < num_3.Length; f++)
                    {
                        num_1[f] = num_3[f];
                    }
                    Console.WriteLine("Массив очищен, введите порядковый номер необходимого действия: " +
                        "1 - Продолжить " +
                        "2 - Выйти ");
                    string? choice1 = Console.ReadLine();
                    if (choice1 == "1")
                    {
                        continue;
                    }
                    else if (choice1 == "2")
                    {
                        Console.WriteLine($"Кол-во введенных элементов: {i}");
                        Console.WriteLine($"Кол-во ошибок: {err}");
                        break;
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine($"Кол-во введенных элементов: {i}");
                    Console.WriteLine($"Кол-во ошибок: {err}");
                    break;
                }
            }
            else if (num_1[i] != "0" && num_1[i] != "1" && num_1[i] != "2" && num_1[i] != "3" && num_1[i] != "4" && num_1[i] != "5"
                && num_1[i] != "6" && num_1[i] != "7" && num_1[i] != "8" && num_1[i] != "9") // Ограничения на вовод
            {
                Console.WriteLine("Введены некорректные данные! Необходимо ввести число от 1 до 9!");
                err++; // Счетчик ошибок
                continue;
            }
            i++;
        }
        // Выполняется при переполнение массива
        if (i == num_1.Length)
        {
            var num_2 = new string[size + 1000];
            for (int j = 0; j < num_1.Length; j++)
            {
                num_2[j] = num_1[j];
            }
            while (i < num_2.Length)
            {
                Console.Write("Введите число: ");
                num_2[i] = Console.ReadLine();
                if (num_2[i] == "Q") // Условия стоп-символа
                {
                    Console.WriteLine("");
                    Console.WriteLine("Был указан стоп-символ, введите порядковый номер необходимого действия: ");
                    Console.WriteLine("1 - Продолжить");
                    Console.WriteLine("2 - Очистить");
                    Console.WriteLine("3 - Выйти ");
                    Console.WriteLine("");
                    Console.Write("Номер: ");
                    string? choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        continue;
                    }
                    else if (choice == "2")
                    {
                        var num_4 = new string[size + 1000];
                        for (int k = 0; k < num_4.Length; k++)
                        {
                            num_2[k] = num_4[k];
                        }
                        Console.WriteLine("Массив очищен, введите порядковый номер необходимого действия: " +
                            "1 - Продолжить " +
                            "2 - Выйти ");
                        string? choice1 = Console.ReadLine();
                        if (choice1 == "1")
                        {
                            continue;
                        }
                        else if (choice1 == "2")
                        {
                            Console.WriteLine($"Кол-во введенных элементов: {i}");
                            Console.WriteLine($"Кол-во ошибок: {err}");
                            break;
                        }
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine($"Кол-во введенных элементов: {i}");
                        Console.WriteLine($"Кол-во ошибок: {err}");
                        break;
                    }
                }
                else if (num_2[i] != "0" && num_2[i] != "1" && num_2[i] != "2" && num_2[i] != "3" && num_2[i] != "4" && num_2[i] != "5"
                && num_2[i] != "6" && num_2[i] != "7" && num_2[i] != "8" && num_2[i] != "9") // Ограничения на вовод
                {
                    Console.WriteLine("Введены некорректные данные! Необходимо ввести число от 1 до 9!");
                    err++; // Счетчик ошибок
                    continue;
                }
                i++;
            }
        } 
}

catch (Exception ex)
{
    Console.WriteLine($"что-то пошло не так: {ex.Message}");
}
