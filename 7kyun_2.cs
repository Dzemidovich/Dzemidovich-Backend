using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        // Задаем массив гласных, которые нужно удалить
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };


        foreach (char vowel in vowels)
        {
            str = str.Replace(vowel.ToString(), ""); // Заменяем каждую гласную на пустую строку
        }

        return str;
    }
}