using Tyuiu.GalimovaAS.Sprint3.Task0.V22.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 32.328;

            Assert.AreEqual(res, wait);


        }
    }
}