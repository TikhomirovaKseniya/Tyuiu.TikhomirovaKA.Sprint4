using Tyuiu.TikhomirovaKA.Sprint4.Task7.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Обработка структурных типов                                      *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #21                                                            *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        string str = "425963128528"; int n = 4; int m = 3;
        Console.WriteLine(str);

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        int res = ds.Calculate(n, m, str);
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(str[i * m + j].ToString());
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Сумма чётных чисел массива: " + res);
        Console.ReadKey();
    }
}