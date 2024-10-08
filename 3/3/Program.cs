class Program
{
    static void Main()
    {
        // Приклад масиву цілих чисел
        int[] numbers = { 5, 8, 13, 22, 35, 40, 55, 60 };

        Console.WriteLine("Парні числа у масиві:");

        // Перевіряємо кожен елемент масиву
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}