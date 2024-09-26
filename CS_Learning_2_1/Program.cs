try
{
    int[] nums1 = new int[5];

    Console.Write("Введите первое число: ");
    nums1[0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    nums1[1] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите третье число: ");
    nums1[2] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите четвертое число: ");
    nums1[3] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите пятое число: ");
    nums1[4] = Convert.ToInt32(Console.ReadLine());

    double num1 = (double)(nums1[0] + nums1[1] + nums1[2] + nums1[3] + nums1[4]) / nums1.Length;

    Console.WriteLine(num1);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Все кончено, в любом случае");
}
