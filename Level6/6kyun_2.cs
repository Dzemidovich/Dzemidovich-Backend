using System;

public class Kata
{
    public static int Solve(string s)
    {
        const string vowels = "aeiou"; // Строка гласных
        int maxSum = 0;
        int currentSum = 0;

        foreach (char c in s)
        {
            if (vowels.IndexOf(c) == -1) 
            {
                currentSum += c - 'a' + 1; 
                maxSum = Math.Max(maxSum, currentSum); // Обновляем максимальную сумму
            }
            else
            {
                currentSum = 0; // Сброс текущей суммы при встрече гласной
            }
        }

        return maxSum;
    }
}
