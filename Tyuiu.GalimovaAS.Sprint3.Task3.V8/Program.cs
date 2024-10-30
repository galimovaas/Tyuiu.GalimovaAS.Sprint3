using Tyuiu.GalimovaAS.Sprint3.Task3.V8.Lib;
namespace Tyuiu.GalimovaAS.Sprint3.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Галимова А.С.. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                        *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                                     *");
            Console.WriteLine("* Задание #3                                                                                       *");
            Console.WriteLine("* Вариант #8                                                                                      *");
            Console.WriteLine("* Выполнила: Галимова А.С. | АСОиУБ - 24-1                                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу, используя цикл foreach, удалить все буквы и знаки препинания, оставить цифру *");
            Console.WriteLine("* затем преобразовать в число в строке: ?ds!! 5gh.s!                                               *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string value = "vc,x12fc fc!e";
            int wait = 12;

            Console.WriteLine(" Исходная строка = " + value);
            Console.WriteLine(" Искомый символ = " + wait);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine(" Символ = " + ds.ConvertStringToInt(value));

            Console.ReadKey();
        }
    }
}
