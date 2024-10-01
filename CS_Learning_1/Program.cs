Console.WriteLine("Programm_1");
Console.Write("Введите свою Фамилию: ");
string? second_name = Console.ReadLine();
Console.Write("Введите свое Имя: ");
string? name = Console.ReadLine();
Console.Write("Введите свое Отчество: ");
string? third_name = Console.ReadLine();
Console.WriteLine($"ФИО: {second_name} {name} {third_name}");
Console.WriteLine("");
Console.WriteLine("Programm_2");
Console.Write("Введите первое число - a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Укажите математический знак между числами a и b: ");
string? sign_1 = Console.ReadLine();
switch (sign_1)
{
    case "+":
        double y_1 = (double)(a + b) / 3;
        Console.WriteLine($"Результат: (a + b) / 3 = {y_1}");
        break;
    case "-":
        double y_2 = (double)(a - b) / 3;
        Console.WriteLine($"Результат: (a - b) / 3 = {y_2}");
        break;
    case "*":
        double y_3 = (double)(a * b) / 3;
        Console.WriteLine($"Результат: (a * b) / 3 = {y_3}");
        break;
    case "/":
        double y_4 = (double)(a / b) / 3;
        Console.WriteLine($"Результат: (a / b) / 3 = {y_4}");
        break;
}
