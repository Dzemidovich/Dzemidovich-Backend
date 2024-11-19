using System;
using System.Text;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        string numberStr = num.ToString();
        int length = numberStr.Length;
        StringBuilder result = new StringBuilder(); 
        for (int i = 0; i < length; i++)
        {
            if (numberStr[i] != '0') 
            {
                long value = (numberStr[i] - '0') * (long)Math.Pow(10, length - i - 1);

                if (result.Length > 0)
                {
                    result.Append(" + ");
                }
                result.Append(value); // Добавляем значение
            }
        }

        return result.ToString(); 
    }
}
