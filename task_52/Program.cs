// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int m, int n)

{
	int[,] matrix = new int[m, n];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		
		{
			matrix[i, j] = new Random().Next(1, 10);
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

double SimpleAverageRows (int[,] matrix)

{
	int simpleA
	for (int i = 0; i < matrix.GetLength(0); i++)
	
	{
		for (int j = 0; j < matrix.GetLe(1); j++)
		{

		}
	}
}



int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
