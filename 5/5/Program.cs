class Program
{
    static void Main()
    {
        // Приклад масиву цілих чисел
        int[] numbers = { 5, 10, 3, 8, 15, 3, 7 };

        Console.Write("Введіть елемент для пошуку: ");
        int target = int.Parse(Console.ReadLine());

        int index = FindFirstIndex(numbers, target);

        if (index != -1)
        {
            Console.WriteLine($"Найменший індекс елемента {target}: {index}");
        }
        else
        {
            Console.WriteLine($"Елемент {target} не знайдено у масиві.");
        }
    }

    // Функція для знаходження найменшого індексу заданого елемента
    static int FindFirstIndex(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; // Повертаємо індекс першого знайденого елемента
            }
        }

        return -1; // Якщо елемент не знайдено
    }
}
