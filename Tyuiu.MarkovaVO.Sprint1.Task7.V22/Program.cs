using Tyuiu.MarkovaVO.Sprint1.Task7.V22.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); ;
            Console.Title = "Спринт #1 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту,                   *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #22                                                                *");
            Console.WriteLine("* Выполнил: Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным *");
            Console.WriteLine("* значениям данных, вводимых пользователем. Ответ округлите до 3 знаков      *");
            Console.WriteLine("* после запятой.                                                             *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("(1-tan(x))^ctg(x)+cos(x-y)=");
            double x, y;

            Console.WriteLine("введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine( ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
