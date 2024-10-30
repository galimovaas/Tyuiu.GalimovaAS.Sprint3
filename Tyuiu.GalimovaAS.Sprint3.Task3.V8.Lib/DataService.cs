using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovaAS.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string str = "vc,x12fc fc!e";
            string result = "";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                { result += c; }
            }
            int number = Int32.Parse(result);
            return number;
        }
    }
}
