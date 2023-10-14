// Задача 3: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"{String.Join(", ", FindMin(matrix))}");
Console.WriteLine();
PrintArray(TrimmArray(matrix, FindMin(matrix)));

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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] FindMin(int[,] matrix)
{
    int minValue = matrix[0, 0];
    int[] minIndex = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLe ngth(1); j++)
        
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        
    }
    return minIndex;
}

int[,] TrimmArray(int[,] matrix, int[] minIndex)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int columns = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == minIndex[0])
            continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
		{	
            if (j == minIndex[1])
                continue;
            result[row, columns] = matrix[i, j];
            columns++;
        }
        columns = 0;
        row++;
    }
    return result;
}
