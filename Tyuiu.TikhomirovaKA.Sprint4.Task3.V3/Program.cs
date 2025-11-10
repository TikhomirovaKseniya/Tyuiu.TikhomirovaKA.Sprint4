using Tyuiu.TikhomirovaKA.Sprint4.Task3.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Обработка структурных типов                                      *");
        Console.WriteLine("* Задание #3                                                             *");
        Console.WriteLine("* Вариант #3                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        int[,] array = new int[,]
        {
            { 9, 4, 5, 4, 8 },
            { 7, 6, 7, 7, 4 },
            { 4, 4, 3, 5, 6 },
            { 6, 5, 9, 4, 9 },
            { 9, 7, 8, 7, 7 } 
        };
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