using Tyuiu.MarkovaVO.Sprint1.Task0.V17.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task0.V17
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
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #17                                                                *");
            Console.WriteLine("* Выполнил: Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 9 / 3 * 2 + 12 / 4 / 3 - 2 *");
            Console.WriteLine("* и напечатать результат на экране                                           *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* 9 / 3 * 2 + 12 / 4 / 3 - 2                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
