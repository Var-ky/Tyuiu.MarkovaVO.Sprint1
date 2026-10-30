using Tyuiu.MarkovaVO.Sprint1.Task3.V15.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double v1 = 2;
            double v2 = 3;
            double S = 5;
            double T = 2;
            double wait = 15;
            var res = ds.DistanceOverTime(v1,v2, S,T);
            Assert.AreEqual(wait, res);
        }
    }
}
