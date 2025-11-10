using System.Security.Cryptography;
using Tyuiu.TikhomirovaKA.Sprint4.Task2.V1.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint4.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomNumberGenerator.GetInt32(9);
            }
            int wait = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) wait *= array[i];
            }
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
