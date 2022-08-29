// Задача 57: Составить частотный словарь элементов
//двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент
//входных данных.

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
void FindCountElements(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        bool found = false;
        int count = 0;
        foreach (int number in arr)
            if (number == row)
            {
                found = true;
                count++;
            }
            if (found)
        Console.WriteLine("Цифра " + row + " встречается " + count + " раз.");
    }
}

int[,] array = CreateMatrix(5, 5, 1, 3);
PrintMatrix(array);
Console.WriteLine();
FindCountElements(array);

