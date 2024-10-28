using Tyuiu.GalimovaAS.Sprint3.Task1.V9.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 4;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 10393093.807;
            Assert.AreEqual(wait, res);

        }
    }
}