class Program
{
    static void Main()
    {
        // Приклад масиву цілих чисел
        int[] numbers = { 10, 20, 30, 40, 50 };

        int sum = 0;

        // Обчислюємо суму елементів масиву
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        // Обчислюємо середнє арифметичне
        double average = (double)sum / numbers.Length;

        Console.WriteLine($"Середнє арифметичне масиву: {average}");
    }
}
