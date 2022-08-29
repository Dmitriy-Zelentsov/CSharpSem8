// Задача 55: Задайте двумерный массив. Напишите
//программу, которая заменяет строки на столбцы. В
//случае, если это невозможно, программа должна
//вывести сообщение для пользователя.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[,] TransporateMatrix(int[,] arr)
{
    int[,] transMatrix = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
           transMatrix[column, row] = arr[row, column];
        }
    }
    return transMatrix;
}

int[,] array = CreateMatrix(5, 3, 2, 3);
PrintMatrix(array);
Console.WriteLine();
TransporateMatrix(array);
PrintMatrix(array);


