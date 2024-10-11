class Program
{
    static void Main()
    {
        // Приклад масиву цілих чисел
        int[] numbers = { -5, 10, -3, 8, -2, 0, 15 };

        // Викликаємо функцію для обчислення добутку від'ємних елементів
        int productOfNegatives = ProductOfNegativeElements(numbers);

        if (productOfNegatives != 1)
        {
            Console.WriteLine($"Добуток всіх від'ємних елементів: {productOfNegatives}");
        }
        else
        {
            Console.WriteLine("В масиві немає від'ємних елементів.");
        }
    }

    // Функція для знаходження добутку всіх від'ємних елементів масиву
    static int ProductOfNegativeElements(int[] array)
    {
        int product = 1;
        bool hasNegative = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                product *= array[i];
                hasNegative = true;
            }
        }

        return hasNegative ? product : 1;
    }
}
