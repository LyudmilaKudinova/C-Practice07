// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max) 
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); ++row)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($" {arr[row, column]} | ");
        }
        Console.WriteLine();
    }

}

void ArithmeticMeanOfTheColumns(int[,] arr)
{
    double[] sum = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum[i] += arr[j, i];
        }
    }
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double result = 0;
        result = Math.Round(sum[i] / arr.GetLength(0), 1);
            Console.Write($"{result}; ");
    }
    Console.WriteLine("- среднее арифметическое элементов в каждом столбце");
}

int[,] matrix = CreateMatrix(5, 3, 10, 100);
PrintMatrix(matrix);
ArithmeticMeanOfTheColumns(matrix);