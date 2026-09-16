using System;
namespace Task2
{
 class Program
{
    static void Main()
    {
        int n;

        // Валидация N: должно быть целым и > 0
        while (true)
        {
            Console.Write("Введите количество элементов: ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
            Console.WriteLine("Ошибка: N должно быть целым положительным числом.");
        }

        int[] arr = new int[n];

        // Ввод элементов
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Элемент [{i}]: ");
                    arr[i] = int.Parse(Console.ReadLine() ?? "");
                    break; // успешно — выходим из внутреннего while
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }
        }

        Console.WriteLine("Исходный массив: " + string.Join(", ", arr));

        // Реверс: клонируем, чтобы не портить оригинал
        int[] reversed = (int[])arr.Clone();
        Array.Reverse(reversed);
        Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

        // Сортировка
        int[] sorted = (int[])arr.Clone();
        Array.Sort(sorted);
        Console.WriteLine("Отсортированный: " + string.Join(", ", sorted));

        // Max/Min без LINQ — линейный проход
        int max = arr[0], min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }

        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Минимум: " + min);
    }
}

}
