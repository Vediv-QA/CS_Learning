//  Имеется 1 курица в клетке. Курицу необходимо кормить зерном и после она высиживает яйцо.
//  Возможные действия за один ход: 
//  - покормить курицу
//  - забрать яйцо
//  - ничего не делать
//  Если курица не накормлена, то она умирает. За раз положить допускается 3-5 зерен.
//  При условии если курица накормлена, то яйцо высиживается в этот ход и только одно
//  Яйца можно собирать, пока просто выводите счётчик сколько яиц у курицы и сколько игрок собрал яиц

//  Да, Курицу надо кормить каждый ход (ну или если хочется можете настроить раз в какое время)

//  Конечной цели как таковой нет
//  Просто изучение как правильно писать код :)
//  Если будет желание, то правила можно доработать до какого-то "играбельного" вида :)


int chikenEgg = 0;
int playerEgg = 0;
bool chikenLive = true;

while (chikenLive)
{
    try 
    { 
        Console.WriteLine("");
        Console.WriteLine("Помогите курочке выполнить ее священный долг - заберите 10 снесенных яиц!");
        Console.Write("Выберите действие:\n1 - Покормить курочку\n2 - Забрать яйца\n3 - Ничего не делать\nВыбор: ");
        int action = Convert.ToInt32(Console.ReadLine());
        if (action == 1)
        {
            bringFood();
        }
        else if (action == 2)
        {
            collectEgg();
        }
        else if (action == 3)
        {
            doNothing();
        }
        else
        {
            Console.WriteLine("Такого варианта нет, корректно выберите действие!");
            continue;
        }

        if (chikenEgg == 10)
        {
            collectEgg();
        }
    }
    catch (Exception) 
    {
        Console.WriteLine("Такого варианта нет, корректно выберите действие!");
        continue;
    }
}
void bringFood()
{
    Console.WriteLine("Кормим курочку зерном! Укажите кол-во зернышек: ");
    int corn = Convert.ToInt32(Console.ReadLine());
    if (corn >= 3 && corn <= 5)
    {
        chikenEgg++;
        Console.WriteLine($"\nКурочка снесла {chikenEgg}-е яйцо!");
    }
    else if (corn > 5)
    {
        Console.WriteLine("Курочка переела! Слишком много зерен!");
        chikenLive = false;
    }
    else
    {
        Console.WriteLine("Курочка недоела! Слишком мало зерен!");
        chikenLive = false;
    }
}
void collectEgg()
{
    Console.WriteLine("Забираем у курочки яйца");
    playerEgg = chikenEgg;
    chikenLive = false;
}
void doNothing()
{
    Console.WriteLine("Ничего не делаем");
    chikenLive = false;
}
if (playerEgg == 10)
{
    Console.WriteLine($"\nИгра успешно завершена, собрано {playerEgg} яиц! Курочка выполнила свой долг! Мы будем помнить ее!");
}
else
{
    Console.WriteLine($"\nИгра провалена, собранное кол-во яиц = {playerEgg}! Курочка погибла и не выполнила свой долг, вы плохой фермер!");
}