using Tyuiu.MarkovaVO.Sprint1.Task6.V17.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "Шалаш";
            var res = ds.CheckPalindrome(value);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
