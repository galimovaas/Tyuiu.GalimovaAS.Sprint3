using Tyuiu.GalimovaAS.Sprint3.Task4.V13.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startVale = -5;
            int stopValue = 5;

            double res = ds.Calculate(startVale, stopValue);

            double wait = 1.899;
            Assert.AreEqual(wait, res);
        }
    }
}