public static class Kata
{
    public static object[] RemoveEveryOther(object[] arr)
    {

        List<object> result = new List<object>();

        // Перебираем массив и добавляем только элементы с четным индексом (0, 2, 4...)
        for (int i = 0; i < arr.Length; i += 2)
        {
            result.Add(arr[i]);
        }

        // Преобразуем список обратно в массив и возвращаем
        return result.ToArray();
    }
}