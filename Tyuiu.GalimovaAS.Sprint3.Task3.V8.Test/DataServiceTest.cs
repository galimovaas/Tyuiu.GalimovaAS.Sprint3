using Newtonsoft.Json.Linq;
using Tyuiu.GalimovaAS.Sprint3.Task3.V8.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "vc,x12fc fc!e";

            int wait = 12;

            int res = ds.ConvertStringToInt(str);
            Assert.AreEqual(wait, res);
        }
    }
}