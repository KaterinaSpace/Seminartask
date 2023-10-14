// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 15);
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
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }
}

// void AverageRows(int[,] matrix)
// {
// 		int rows = matrix.GetLength(0);

// 		for (int j = 0; j < matrix.GetLength(1); j++)
// {
// 				int sum = 0;

// 		for (int i = 0; i < matrix.GetLength(0); i++)
// 		{
// 				sum += matrix[i, j];
// 		}
// 		Console.Write($"{(double)sum / rows}   ");
// }
// }

//функция, считающая суму элементов в строке
int SumStroke(int[,] matrix)
{
    int indexMinSumStroke = 0;
    int sumMinStroke = Int32.MaxValue;
    ;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{sum}    ");
        if (sum < sumMinStroke)
        {
            sumMinStroke = sum;
            indexMinSumStroke = i;
        }
    }
    return indexMinSumStroke;
}

int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
Console.WriteLine();

int minStroke = SumStroke(matrix);
Console.WriteLine($" номер строки с наименьшей суммой элементов:{minStroke + 1}");




// AverageRows(matrix);
