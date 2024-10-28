using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GalimovaAS.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                multSeries = multSeries * (Math.Pow((300 / (Math.Cos(value) + Math.Pow(value, startValue))), startValue));

            }
            return Math.Round(multSeries, 3);
        }   
    }
}
