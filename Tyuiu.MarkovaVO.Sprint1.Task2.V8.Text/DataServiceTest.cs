using Tyuiu.MarkovaVO.Sprint1.Task2.V8.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task2.V8.Text
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(10, res);
        }
    }
}
