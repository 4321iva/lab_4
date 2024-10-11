class Program
{
    static void Main()
    {
        // Приклад двовимірного масиву (матриці)
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Викликаємо функцію для обчислення суми елементів по головній діагоналі
        int sum = SumOfMainDiagonal(matrix);

        Console.WriteLine($"Сума елементів по головній діагоналі: {sum}");
    }

    // Функція для знаходження суми елементів по головній діагоналі
    static int SumOfMainDiagonal(int[,] matrix)
    {
        int sum = 0;
        int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1)); // Визначаємо розмір для квадратних матриць

        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
}

