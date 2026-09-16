using System;
using System.Linq;

// Final.Task, вариант 1
class Program
{
    static void Main()
    {
        double[] temperatures = { 22.5, 23.1, 19.8, 21.3, 24.0, 25.2, 28.7 };

        double avg = temperatures.Average();
        double max = temperatures.Max();
        double min = temperatures.Min();
        int above20 = temperatures.Count(t => t > 20);

        Console.WriteLine($"Средняя температура: {avg:F1}");
        Console.WriteLine($"Максимальная: {max:F1}");
        Console.WriteLine($"Минимальная: {min:F1}");
        Console.WriteLine($"Дней выше 20 °C: {above20}");
    }
}