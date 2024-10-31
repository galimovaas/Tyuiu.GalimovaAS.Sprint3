using Tyuiu.GalimovaAS.Sprint3.Task6.V6.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                *");
            Console.WriteLine("* Тема: Вложенные циклы                                                                    *");
            Console.WriteLine("* Задание #6                                                                               *");
            Console.WriteLine("* Вариант #6                                                                               *");
            Console.WriteLine("* Выполнила: Галимова А.С. | АСОиУБ - 24-1                                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку      *");
            Console.WriteLine("* [16, 24] количество всех делителей больше 10                                             *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int startValue = 16;
            int stopValue = 24;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, startValue));

            Console.ReadKey();
        }
    }
}
