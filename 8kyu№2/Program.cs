using System;

public static class Kata
{
    public static int Enough(int cap, int on, int wait)
    {
        // Рассчитываем, сколько мест останется на автобусе
        int availableSpace = cap - on;

        // Если доступного места достаточно для всех ожидающих
        if (availableSpace >= wait)
        {
            return 0; // Все могут сесть
        }

        // Возвращаем количество пассажиров, которые не смогут сесть
        return wait - availableSpace;
    }
}