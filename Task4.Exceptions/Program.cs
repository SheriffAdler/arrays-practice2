using System;
namespace Task4
{
   class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    arr[i] = int.Parse(Console.ReadLine() ?? "");
                    break;
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

        while (true)
        {
            Console.Write("Введите индекс для вывода (0-4): ");

            // Проверку "это вообще число?" делаем через TryParse,
            // а выход за границы — через try/catch по заданию
            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("Ошибка: Введите целое число!");
                continue;
            }

            try
            {
                Console.WriteLine($"Элемент [{index}]: {arr[index]}");
                break;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Индекс вне границ массива.");
            }
        }
    }
}
}
