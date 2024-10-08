class Program
{
    static void Main()
    {
        // Приклад масиву цілих чисел
        int[] numbers = { 1, 2, 3, 2, 1 };

        bool isPalindrome = true;

        // Перевіряємо, чи є масив паліндромом
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            if (numbers[i] != numbers[numbers.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Масив є паліндромом.");
        }
        else
        {
            Console.WriteLine("Масив не є паліндромом.");
        }
    }
}