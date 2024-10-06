try
{
    int arrIndex = 0;                   //номер элемента массива
    int arrErr = 0;                    //счетчик ошибок пользователя
    string? arrStop = "Q";            //стоп символ
    double[] arr_1 = new double[5];  //стартовый массив

    while (true)
    {
        try
        {
            Console.Write("Введите число или стоп-символ Q: ");
            string? input = Console.ReadLine();
            if (input.ToUpper().Contains(arrStop))
            {
                Console.WriteLine("\nСозданный массив: ");
                showArray();
                Console.Write("\nБыл указан стоп-символ, что делать дальше?:\n1 - Продолжить\n2 - Очистить\n3 - Выйти\nВыбор: ");
                string? choice = Console.ReadLine();
                if (choice == "1")
                {
                    continue;
                }
                else if (choice == "2")
                {
                    arr_1 = new double[5];
                    arrIndex = 0;
                    Console.WriteLine("\nМассив очищен^_^");
                    Console.WriteLine($"Кол-во символов в массиве: {arrIndex}");
                    Console.WriteLine($"Кол-во ошибок: {arrErr}");
                    Console.Write("Что делать дальше?:\n1 - Продолжить\n2 - Выйти\nВыбор: ");
                    string? choice_1 = Console.ReadLine();
                    if (choice_1 == "1")
                    {
                        continue;
                    }
                    else if (choice_1 == "2")
                    {
                        Console.WriteLine($"Кол-во символов в массиве: {arrIndex}");
                        Console.WriteLine($"Кол-во ошибок: {arrErr}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Такого варианта нет");
                        break;
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine($"Кол-во символов в массиве: {arrIndex}");
                    Console.WriteLine($"Кол-во ошибок: {arrErr}");
                    break;
                }
                else
                {
                    Console.WriteLine("Такого варианта нет");
                    arrErr++;
                    break;
                }
            }
            else
            {
                var arrSymbol = double.Parse(input);
                if (arrIndex < arr_1.Length)
                {
                    arr_1[arrIndex] = arrSymbol;
                    increaseArray();
                }
            }

        }
        catch (Exception)
        {
            Console.WriteLine("\nВведен некорректный символ!");
            Console.WriteLine("Созданный массив: ");
            showArray();
            Console.WriteLine("");
            arrErr++;
            continue;
        }
    }

    void showArray()
    {
        for (int i = 0; i < arrIndex; i++)
        {
            Console.Write($"{arr_1[i]} ");
        }
    }
    void increaseArray()
    {
        double[] arr_2 = new double[arr_1.Length * 2];
        for (int i = 0; i < arr_1.Length; i++)
        {
            arr_2[i] = arr_1[i];
        }
        arr_1 = arr_2;
        arrIndex++;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"что-то пошло не так: {ex.Message}");
}
