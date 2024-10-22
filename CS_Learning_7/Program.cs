//ДЗ 7
//1. Записать что-то в файл, прочитать что-то из файла
//можно сделать что-то вроде простого блокнота, 
//который записывает в файл всё то что пользователь туда записывает
//2. Расширяем функционал прошлого задания - возможность сохранять в разные файлы 
//(спрашивать у пользователя куда сохранить)
//3. Предлагать пользователю открыть дописать в какой-то в файл 
//(допустим все заметки сохраняются в одну папку и выводить пользователю 
//список файлов и просить выбрать какой открыть)

string? choice = "";
while (choice != "4")
{
    Console.WriteLine("Выберите действие:\n1 - Создать новый файл\n2 - Добавить запись в существующий файл\n3 - Прочитать информацию из файла\n4 - Закрыть программу");
    choice = Console.ReadLine();
    {
        switch (choice)
        {
            case "1":
                createFile();
                break;
            case "2":
                AddInfo();
                break;
            case "3":
                ReadFile();
                break;
            case "4":
                Console.WriteLine("Закрытие программы");
                break;
            default:
                Console.WriteLine("Такого варианта нет, корректно выберите действие!\n");
                break;
        }
    }
}
void createFile()
{
    Console.Write("Введите имя создаваемого файла: ");
    string? newfile = Console.ReadLine() + ".txt";
    if (!File.Exists(newfile))
    {
        Console.Write("Введите текст файла: ");
        File.WriteAllText(newfile, $"{Environment.NewLine}{Console.ReadLine()}");
    }
    else
    {
        Console.WriteLine("Файл с указанным именем уже существует!\n");
    }
}
void AddInfo()
{
    Console.Write("Введите имя файла, в который необходимо добавить информацию: ");
    string? file = Console.ReadLine() + ".txt";
    if (File.Exists(file))
    {
        Console.Write("Введите добавляемый в файл текст: ");
        File.AppendAllText(file, $"{Environment.NewLine}{Console.ReadLine()}");
    }
    else
    {
        Console.WriteLine("Не существует файла с указанным именем!\n");
    }
}
void ReadFile()
{
    ShowFiles();
    Console.Write("\nУкажите имя файла из списка, информацию из которого необходимо прочитать: ");
    string? file = Console.ReadLine() + ".txt";
    if (File.Exists(file))
    {
        var info = File.ReadAllText(file);
        Console.WriteLine(info);
    }
    else
    {
        Console.WriteLine("Не существует файла с указанным именем!\n");
    }
}
void ShowFiles()
{
    string[] files = Directory.GetFiles(Environment.CurrentDirectory);
    foreach (string file in files)
    {
        Console.WriteLine(file);   
    }
}