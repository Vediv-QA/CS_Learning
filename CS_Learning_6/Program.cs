//по ДЗ 6:
//использовать enum в игре с курицей
//В игре с курицей сделать теперь 3 курицы

Console.WriteLine("");
Console.WriteLine("Помогите трём курочкам выполнить их священный долг - заберите у каждой курочки 10 снесенных яиц!");
Console.WriteLine("Чтобы выбранная курочка снесла яйцо, кормите ее каждый ход 3-5 зернышками!");
Console.WriteLine("Если курочку не покормить один ход, то она умирает!");
int atosEgg = 0;
int partosEgg = 0;
int aramisEgg = 0;
int player_atosEgg = 0;
int player_partosEgg = 0;
int player_aramisEgg = 0;
bool chikenLive_1 = true;
bool chikenLive_2 = true;
bool chikenLive_3 = true;
ChickenName chikenName = ChickenName.Atos;
while (chikenLive_1 | chikenLive_2 | chikenLive_3)
{
    try
    {
        Console.WriteLine("");
        Console.Write("Выберите курочку:\n1 - Атос\n2 - Партос\n3 - Арамис\nВыбор: ");
        int chiken = Convert.ToInt32(Console.ReadLine());
        if (chiken == 1)
        {
            chikenName = ChickenName.Atos;
            Console.WriteLine("");
            Console.WriteLine("Вы выбрали курочку по имени Атос");
            if (chikenLive_1 == false)
            {
                Console.WriteLine("Курочка Атос уже умерла, выберите другую курочку!");
                continue;
            }
        }
        if (chiken == 2)
        {
            chikenName = ChickenName.Partos;
            Console.WriteLine("");
            Console.WriteLine("Вы выбрали курочку по имени Партос");
            if (chikenLive_2 == false)
            {
                Console.WriteLine("Курочка Партос уже умерла, выберите другую курочку!");
                continue;
            }
        }
        if (chiken == 3)
        {
            chikenName = ChickenName.Aramis;
            Console.WriteLine("");
            Console.WriteLine("Вы выбрали курочку по имени Арамис");
            if (chikenLive_3 == false)
            {
                Console.WriteLine("Курочка Арамис уже умерла, выберите другую курочку!");
                continue;
            }
        }
        if (chiken != 1 && chiken != 2 && chiken != 3)
        {
            Console.WriteLine("Такого варианта нет, корректно выберите действие!");
            continue;
        }

        while (true)
        { 
            if (chikenName == ChickenName.Atos)
            {
                Console.Write("Выберите действие:\n1 - Покормить курочку\n2 - Забрать яйца\n3 - Ничего не делать\nВыбор: ");
                chooseAction();
                if (atosEgg == 10)
                {
                    collectEgg();
                    break;
                }
                else if (chikenLive_1 == false)
                {
                    break;
                }
            }
            if (chikenName == ChickenName.Partos)
            {
                Console.Write("Выберите действие:\n1 - Покормить курочку\n2 - Забрать яйца\n3 - Ничего не делать\nВыбор: ");
                chooseAction();
                if (partosEgg == 10)
                {
                    collectEgg();
                    break;
                }
                else if (chikenLive_2 == false)
                {
                    break;
                }
            }
            if (chikenName == ChickenName.Aramis)
            {
                Console.Write("Выберите действие:\n1 - Покормить курочку\n2 - Забрать яйца\n3 - Ничего не делать\nВыбор: ");
                chooseAction();
                if (aramisEgg == 10)
                {
                    collectEgg();
                    break;
                }
                else if (chikenLive_3 == false)
                {
                    break;
                }
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Такого варианта нет, корректно выберите действие!");
        continue;
    }
}
void chooseAction()
{
    int action = Convert.ToInt32(Console.ReadLine());
    switch (action)
    {
        case 1:
            bringFood();
            break;
        case 2:
            collectEgg();
            break;
        case 3:
            doNothing();
            break;
        default:
            Console.WriteLine("Такого варианта нет, корректно выберите действие!");
            break;
    }
}
void bringFood()
{
    Console.WriteLine("Кормим курочку зерном! Укажите кол-во зернышек: ");
    int corn = Convert.ToInt32(Console.ReadLine());
    if (corn >= 3 && corn <= 5)
    {
        if (chikenName == ChickenName.Atos)
        {
            atosEgg++;
            Console.WriteLine($"\nКурочка Атос снесла {atosEgg}-е яйцо!");
        }
        if (chikenName == ChickenName.Partos)
        {
            partosEgg++;
            Console.WriteLine($"\nКурочка Партос снесла {partosEgg}-е яйцо!");
        }
        if (chikenName == ChickenName.Aramis)
        {
            aramisEgg++;
            Console.WriteLine($"\nКурочка Партос снесла {aramisEgg}-е яйцо!");
        }
    }
    else if (corn > 5)
    {
        Console.WriteLine("Курочка переела! Слишком много зерен!");
        if (chikenName == ChickenName.Atos)
        {
            chikenLive_1 = false;
        }
        if (chikenName == ChickenName.Partos)
        {
            chikenLive_2 = false;
        }
        if (chikenName == ChickenName.Aramis)
        {
            chikenLive_3 = false;
        }
    }
    else
    {
        Console.WriteLine("Курочка недоела! Слишком мало зерен!");
        if (chikenName == ChickenName.Atos)
        {
            Console.WriteLine("Курочка Атос погибла!");
            chikenLive_1 = false;
        }
        if (chikenName == ChickenName.Partos)
        {
            Console.WriteLine("Курочка Партос погибла!");
            chikenLive_2 = false;
        }
        if (chikenName == ChickenName.Aramis)
        {
            Console.WriteLine("Курочка Арамис погибла!");
            chikenLive_3 = false;
        }
    }
}
void collectEgg()
{
    Console.WriteLine("Забираем у курочки яйца");
    if (chikenName == ChickenName.Atos)
    {
        Console.WriteLine("Курочка Атос погибла");
        player_atosEgg = atosEgg;
        chikenLive_1 = false;
    }
    if (chikenName == ChickenName.Partos)
    {
        Console.WriteLine("Курочка Партос погибла");
        player_partosEgg = partosEgg;
        chikenLive_2 = false;
    }
    if (chikenName == ChickenName.Aramis)
    {
        Console.WriteLine("Курочка Партос погибла");
        player_aramisEgg = aramisEgg;
        chikenLive_3 = false;
    }
}
void doNothing()
{
    Console.WriteLine("Ничего не делаем");
    if (chikenName == ChickenName.Atos)
    {
        Console.WriteLine("");
        Console.WriteLine("Курочка Атос погибла!");
        chikenLive_1 = false;
    }
    if (chikenName == ChickenName.Partos)
    {
        Console.WriteLine("");
        Console.WriteLine("Курочка Партос погибла!");
        chikenLive_2 = false;
    }
    if (chikenName == ChickenName.Aramis)
    {
        Console.WriteLine("");
        Console.WriteLine("Курочка Арамис погибла!");
        chikenLive_3 = false;
    }
}
if (player_atosEgg == 10 && player_partosEgg == 10 && player_aramisEgg == 10)
{
    Console.WriteLine($"\nИгра успешно завершена, собранное кол-во яиц:\nАтос - {player_atosEgg},\nПартос - {player_partosEgg},\nАрамис - {player_aramisEgg}\nКурочки выполнили свой долг! Один за всех и все за одного! Мы будем помнить их!!!");
}
else
{
    Console.WriteLine($"\nИгра провалена, собранное кол-во яиц:\nАтос - {player_atosEgg},\nПартос - {player_partosEgg},\nАрамис - {player_aramisEgg}\nОдна из курочек погибла за всех и все за одну, они не успели выполнить свой долг, вы плохой фермер!");
}
enum ChickenName
{
    Atos,
    Partos,
    Aramis
}

