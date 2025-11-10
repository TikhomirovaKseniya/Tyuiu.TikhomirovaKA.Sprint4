using Tyuiu.TikhomirovaKA.Sprint4.Task1.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Обработка структурных типов                                      *");
        Console.WriteLine("* Задание #1                                                             *");
        Console.WriteLine("* Вариант #8                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int[] array = new int[12] { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(ds.Calculate(array));
        Console.ReadKey();
    }
}