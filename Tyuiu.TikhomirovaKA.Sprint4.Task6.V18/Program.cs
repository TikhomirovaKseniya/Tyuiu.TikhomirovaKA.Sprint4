using Tyuiu.TikhomirovaKA.Sprint4.Task6.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Обработка структурных типов                                      *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #18                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        string[] array = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(string.Join(", ", ds.Calculate(array)));
        Console.ReadKey();
    }
}