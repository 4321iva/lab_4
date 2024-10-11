class Program
{
    static void Main()
    {
        // Приклад квадратної матриці
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        int[,] rotatedMatrix = RotateMatrix90DegreesCounterClockwise(matrix);

        Console.WriteLine("\nМатриця після обертання на 90 градусів проти годинникової стрілки:");
        PrintMatrix(rotatedMatrix);
    }

    // Функція для обертання квадратної матриці на 90 градусів проти годинникової стрілки
    static int[,] RotateMatrix90DegreesCounterClockwise(int[,] matrix)
    {
        int n = matrix.GetLength(0); // Розмірність матриці
        int[,] rotatedMatrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rotatedMatrix[n - j - 1, i] = matrix[i, j];
            }
        }

        return rotatedMatrix;
    }

    // Функція для виведення матриці на екран
    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
