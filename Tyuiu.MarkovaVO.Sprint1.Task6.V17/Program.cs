using Tyuiu.MarkovaVO.Sprint1.Task6.V17.Lib;

namespace Tyuiu.MarkovaVO.Sprint1.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); ;
            Console.Title = "Спринт #1 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Работа со строками класса String                                     *");
            Console.WriteLine("* Задание #6                                                                 *");
            Console.WriteLine("* Вариант #17                                                                *");
            Console.WriteLine("* Выполнил: Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка       *");
            Console.WriteLine("* является перевертышем.                                                     *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string value;

            Console.WriteLine("Введите слово:");
            value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            var res = ds.CheckPalindrome(value);
            if (res == true)
            { Console.WriteLine("Строка является перевёртышем"); }
            
            if (res == false)
            { Console.WriteLine("Строка не является перевёртышем"); }

            Console.ReadLine();
        }
    }
}
