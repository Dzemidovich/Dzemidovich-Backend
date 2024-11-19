using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        
        string result = "";

        foreach (char digit in n.ToString())
        {
           
            result += (int)Math.Pow(char.GetNumericValue(digit), 2);
        }

        return int.Parse(result);
    }
}