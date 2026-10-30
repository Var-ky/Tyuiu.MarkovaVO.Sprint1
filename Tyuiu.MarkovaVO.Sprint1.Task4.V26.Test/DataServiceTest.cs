using Tyuiu.MarkovaVO.Sprint1.Task4.V26.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -2.132267;
            double y = 2.132267;
            double wait = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
