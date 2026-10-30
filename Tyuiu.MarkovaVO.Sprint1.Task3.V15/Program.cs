using Tyuiu.MarkovaVO.Sprint1.Task3.V15.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.MarkovaVO.Sprint1.Task3.V15
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
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #15                                                                *");
            Console.WriteLine("* Выполнил: Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double v1, v2, S,T;

            Console.WriteLine("введите значение v1:");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение v2:");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение S:");
            S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение T:");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Ответ: " + $"{ds.DistanceOverTime(v1, v2, S, T):F3}");

            Console.ReadLine();
        }
    }
}
