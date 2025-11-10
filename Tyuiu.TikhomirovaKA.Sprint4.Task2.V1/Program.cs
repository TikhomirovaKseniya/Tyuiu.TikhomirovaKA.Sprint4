using System.Security.Cryptography;
using Tyuiu.TikhomirovaKA.Sprint4.Task2.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    { 
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Обработка структурных типов                                      *");
        Console.WriteLine("* Задание #2                                                             *");
        Console.WriteLine("* Вариант #1                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = RandomNumberGenerator.GetInt32(1, 9);
        }
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(ds.Calculate(array));
        Console.ReadKey();
    }
}