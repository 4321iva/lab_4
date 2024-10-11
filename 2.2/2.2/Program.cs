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

        Console.Write("Введіть номер стовпця для обчислення добутку (0 - перший стовпець): ");
        int columnIndex = int.Parse(Console.ReadLine());

        // Викликаємо функцію для обчислення добутку елементів стовпця
        int product = ProductOfColumn(matrix, columnIndex);

        if (product != 1)
        {
            Console.WriteLine($"Добуток елементів у стовпці {columnIndex}: {product}");
        }
        else
        {
            Console.WriteLine("Стовпець не існує або містить нуль.");
        }
    }

    // Функція для знаходження добутку всіх елементів вказаного стовпця
    static int ProductOfColumn(int[,] matrix, int columnIndex)
    {
        if (columnIndex < 0 || columnIndex >= matrix.GetLength(1))
        {
            Console.WriteLine("Невірний номер стовпця.");
            return 1; // Якщо номер стовпця невірний
        }

        int product = 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            product *= matrix[i, columnIndex];
        }

        return product;
    }
}

