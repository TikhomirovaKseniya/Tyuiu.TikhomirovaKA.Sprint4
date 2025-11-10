internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Обработка структурных типов                                      *");
        Console.WriteLine("* Задание #0                                                             *");
        Console.WriteLine("* Вариант #15                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int[] array = new int[10] { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(ds.GetMultOddArrEl(array));
        Console.ReadKey();
    }
}