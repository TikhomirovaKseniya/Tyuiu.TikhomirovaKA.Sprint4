using Tyuiu.TikhomirovaKA.Sprint4.Task1.V8.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint4.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int wait = 25;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
