using Tyuiu.GalimovaAS.Sprint3.Task1.V9.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила:  Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                *");
            Console.WriteLine("* Тема: Оператор цикла while                                                                *");
            Console.WriteLine("* Задание #1                                                                               *");
            Console.WriteLine("* Вариант 9                                                                               *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна | АСОиУБ - 24-1                                    *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу используя цикл while,                                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле.                                          *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 4;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
