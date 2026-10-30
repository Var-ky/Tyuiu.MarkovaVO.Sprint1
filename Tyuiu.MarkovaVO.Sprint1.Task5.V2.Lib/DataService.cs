using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MarkovaVO.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double Celsius = (temp - 32) * 5 / 9;
            int res = Convert.ToInt32(Celsius);
            return res;
        }
    }
}
