using Tyuiu.MarkovaVO.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); ;
            Console.Title = "Спринт #1 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                 *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #2                                                                 *");
            Console.WriteLine("* Выполнил: Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                       *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение этой  *");
            Console.WriteLine("* же температуры в градусах Цельсия. Ответ привести к целому с помощью       *");
            Console.WriteLine("* класса Convert.                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double temp;

            Console.WriteLine("Введите значение температуры в градусах Фаренгейта:");
            temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Tемпература в градусах Цельсия:" + ds.FahrenheitToСelsius(temp));

            Console.ReadLine();
        }
    }
}
