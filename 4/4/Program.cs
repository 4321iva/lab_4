class Program
{
    static void Main()
    {
        // Приклад масиву цілих чисел
        int[] numbers = { -5, 10, -3, 8, 15, -2, 0 };

        // Викликаємо функцію для обчислення суми додатних елементів
        int sumOfPositive = SumOfPositiveElements(numbers);

        Console.WriteLine($"Сума всіх додатних елементів: {sumOfPositive}");
    }

    // Функція для знаходження суми додатних елементів масиву
    static int SumOfPositiveElements(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
            }
        }

        return sum;
    }
}