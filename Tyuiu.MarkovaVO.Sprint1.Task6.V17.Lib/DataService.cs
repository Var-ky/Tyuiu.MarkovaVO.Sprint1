using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MarkovaVO.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string res = "";
            string lowerValue = value.ToLower();
            for (var i = 0; i < lowerValue.Length; i++)
            {
                res = lowerValue[i] + res;
            }
            return (res == lowerValue);
        }
    }
}
