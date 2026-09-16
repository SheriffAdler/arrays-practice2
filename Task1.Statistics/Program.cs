using System;
namespace Task1
{
   class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] arr = new int[10];

        // Заполнение массива
        for (int i = 0; i < arr.Length; i++)
            arr[i] = rnd.Next(1, 101); 

        Console.WriteLine("Массив: " + string.Join(", ", arr));

        int sum = 0;
        double product = 1.0;   
        int evenCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            product *= arr[i];
            if (arr[i] % 2 == 0) evenCount++;
        }

        double average = (double)sum / arr.Length;   
        int greaterThanAverage = 0;

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] > average) greaterThanAverage++;

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Произведение: " + product.ToString("0.##E+0"));
        Console.WriteLine("Чётных чисел: " + evenCount);
        Console.WriteLine($"Больше среднего ({average:F1}): {greaterThanAverage}");
    }
}

}
