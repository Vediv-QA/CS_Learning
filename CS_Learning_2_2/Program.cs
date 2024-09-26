try
{
    string?[][] nums = new string[3][];

    nums[0] = new string[2];
    nums[1] = new string[2];
    nums[2] = new string[2];

    Console.Write("Введите имя первого пользователя: ");
    nums[0][0] = Console.ReadLine();

    Console.Write("Введите возраст первого пользователя: ");
    nums[0][1] = Console.ReadLine();
    Console.WriteLine("");

    Console.Write("Введите имя второго пользователя: ");
    nums[1][0] = Console.ReadLine();

    Console.Write("Введите возраст второго пользователя: ");
    nums[1][1] = Console.ReadLine();
    Console.WriteLine("");

    Console.Write("Введите имя третьего пользователя: ");
    nums[2][0] = Console.ReadLine();

    Console.Write("Введите возраст третьего пользователя: ");
    nums[2][1] = Console.ReadLine();
    Console.WriteLine("");

    Console.Write("Порядковый номер человека, данные которого необходимо вывести: ");
    int man = int.Parse(Console.ReadLine());

    if (man == 1)
    {
        string m_1_1 = nums[0][0];
        string m_1_2 = nums[0][1];
        Console.WriteLine($"Данные первого пользователя - Имя: {m_1_1}, Возраст: {m_1_2}");
    }
    else if (man == 2)
    {
        string m_2_1 = nums[1][0];
        string m_2_2 = nums[1][1];
        Console.WriteLine($"Данные второго пользователя - Имя: {m_2_1}, Возраст: {m_2_2}");
    }
    else if (man == 3)
    {
        string m_3_1 = nums[2][0];
        string m_3_2 = nums[2][1];
        Console.WriteLine($"Данные третьего пользователя - Имя: {m_3_1}, Возраст: {m_3_2}");
    }
    else
    {
        Console.WriteLine("Пользователя с указанным порядковым номером не существует");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}