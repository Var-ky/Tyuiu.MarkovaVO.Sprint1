using Tyuiu.MarkovaVO.Sprint1.Task7.V22.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.1;
            double y = 0.2;
            double wait = 1.344;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
