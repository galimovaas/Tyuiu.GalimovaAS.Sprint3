using Tyuiu.GalimovaAS.Sprint3.Task0.V22.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                *");
            Console.WriteLine("* Тема: Оператор цикла for                                                                 *");
            Console.WriteLine("* Задание #0                                                                               *");
            Console.WriteLine("* Вариант #22                                                                              *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна  | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу используя цикл for,                                                   *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при X = 0.25.                                   *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int value = 0.25 ;
            int startValue = 1;
            int stopValue = 8;

            Console.WriteLine("Переменная x = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Сумму ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }

    
}
