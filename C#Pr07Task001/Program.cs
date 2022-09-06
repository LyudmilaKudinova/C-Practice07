// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = Convert.ToDouble(new Random().Next(min, max + 1));
        }
    }
    return array;
}

void PrintMatrix(double[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); ++row)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }

}

double[,] matrix = CreateMatrix(5, 3, -100, 100);
PrintMatrix(matrix);