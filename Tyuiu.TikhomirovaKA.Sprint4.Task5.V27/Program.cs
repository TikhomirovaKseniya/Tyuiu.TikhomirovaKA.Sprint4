using System.Security.Cryptography;
using Tyuiu.TikhomirovaKA.Sprint4.Task5.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Обработка структурных типов                                      *");
        Console.WriteLine("* Задание #5                                                             *");
        Console.WriteLine("* Вариант #27                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int[,] array = new int[5, 5];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = RandomNumberGenerator.GetInt32(-5, 7);
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + ", ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(ds.Calculate(array));
        Console.ReadKey();
    }
}