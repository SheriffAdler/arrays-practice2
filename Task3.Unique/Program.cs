using System;
namespace Task3
{
  class Program
{
    static void Main()
    {
        int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };
        int[] unique = GetUnique(source);

        Console.WriteLine("Исходный: " + string.Join(", ", source));
        Console.WriteLine("Уникальные: " + string.Join(", ", unique));
    }

    public static int[] GetUnique(int[] source)
    {
        // Вспомогательный массив максимум той же длины, что и source
        int[] temp = new int[source.Length];
        int count = 0; // сколько уникальных уже собрано

        for (int i = 0; i < source.Length; i++)
        {
            bool exists = false;

            // Проверяем, есть ли source[i] среди уже собранных
            for (int j = 0; j < count; j++)
            {
                if (temp[j] == source[i])
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                temp[count] = source[i];
                count++;
            }
        }

        // Обрезаем массив до реального размера
        int[] result = new int[count];
        for (int i = 0; i < count; i++)
            result[i] = temp[i];

        return result;
    }
}
}
