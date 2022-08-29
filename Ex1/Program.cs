// Задайте двумерный массив
//Напишите прогу, которая поменяет местами первую и последнюю строку массиваа

int[,] CreateMatrix (int rowCount, int columnCount, int min, int max)
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

void PrintMatrix (int[,] arr)
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

void SwapRows (int[,] arr)
{
    int rowCount = arr.GetLength(0);
     for (int row = 0; row < arr.GetLength(1); row++)
    {
        int temp = arr [0, row];
        arr[0, row] = arr [rowCount -1, row];
        arr [rowCount-1, row] = temp;
    }
}

int [,] array = CreateMatrix(5, 3, 2, 3);
PrintMatrix(array);
Console.WriteLine();
SwapRows (array);
PrintMatrix(array);

