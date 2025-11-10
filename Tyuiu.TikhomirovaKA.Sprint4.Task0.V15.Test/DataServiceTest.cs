using Tyuiu.TikhomirovaKA.Sprint4.Task0.V15.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint4.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int wait = 945;
            int res = ds.GetMultOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}
