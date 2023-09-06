//methods
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 9);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine();
    }
}

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        int[,] temparray = new int[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temparray[i, j] = matrix[j, i];
            }
        }
        return temparray;
    }
    else
    {
        Console.WriteLine("Переворот невозможен");
        return matrix;
    }
}

int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
Console.WriteLine();
PrintArray(ReplaceRowsToColumns(matrix));
