//  ДЗ с математикой:
//  Написать алгоритм поиска Nго простого числа 
//  (к примеру 2, 3, 5, 7 где 2 это 1ое число 3 - второе и т.д., т.е. если N = 4 то на выходе должно быть 7)
//  Для справки:
//  Простое число, это число которое делится без остатка только на себя и на 1

static string get_prime(int n)
{
    int[] arr_1 = new int[10];
    int arrIndex = 0;
    int num = 2;
    while (true)
    {
        int count = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
            else if (count > 2)
            {
                break;
            }
        }
        if (count == 2)   // число простое, добавляем в массив
        {
            arr_1[arrIndex] = num;
            arrIndex++;
        }
        else if (arrIndex == arr_1.Length)  // массив закончился, расширяем
        {
            increaseArray();
        }
        else if (n <= 0)    // проверка на отрицательные числа и ноль
        {
            return "'число убежало, введите корректный номер и оно найдется'";
        }
        else if (n == 1)    // вывод первого простого числа
        {
            return Convert.ToString(arr_1[0]);
        }
        else if (arrIndex == n)     // вывод n-го простого числа
        {
            return Convert.ToString(arr_1[n - 1]);
        }
        num++;
    }
    void increaseArray()
    {
        int[] arr_2 = new int[arr_1.Length * 2];
        for (int i = 0; i < arr_1.Length; i++)
        {
            arr_2[i] = arr_1[i];
        }
        arr_1 = arr_2;
    }
}
try
{
    Console.Write("Введите номер простого числа: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Под указанным номером '{n}', существует простое число: '{get_prime(n)}'");
}
catch (Exception ex)
{
    Console.WriteLine($"что-то пошло не так: {ex.Message}");
}