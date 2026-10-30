using Tyuiu.MarkovaVO.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double temp = 50;
            var result = ds.FahrenheitToСelsius(temp);
            int wait = 10;
            Assert.AreEqual(wait, result);
        }
    }
}
