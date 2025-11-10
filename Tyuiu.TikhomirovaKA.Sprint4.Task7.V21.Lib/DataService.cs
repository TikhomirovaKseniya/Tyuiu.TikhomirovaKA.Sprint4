using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TikhomirovaKA.Sprint4.Task7.V21.Lib
{
    public class DataService : ISprint4Task7V21
    {
        public int Calculate(int n, int m, string value)
        {
            int s = 0;
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[i*m+j].ToString());
                    if (matrix[i, j] % 2 == 0) s += matrix[i, j];
                }
            }
            return s;
        }
    }
}
