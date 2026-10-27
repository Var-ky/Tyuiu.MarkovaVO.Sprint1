using Tyuiu.MarkovaVO.Sprint1.Task1.V16.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); ;
            Console.Title = "Спринт #1 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #16                                                                *");
            Console.WriteLine("* Выполнил: Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* вычисляет результат по формуле x * 5 * a + 2 * y и печатает его на экране. *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double a, x, y;

            Console.WriteLine("введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate(a,x,y));

            Console.ReadLine();
        }
    }
}
