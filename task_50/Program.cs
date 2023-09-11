// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// позиция i = 4, j = 2 -> такой позиции нет
// позиция i = 1, j = 0 -> 5


int[,] GetArray(int m, int n)
{
		int[,] matrix = new int[m, n];
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
						matrix[i, j] = new Random().Next(0, 9);
				}
		}
		return matrix;
}

void PrintArray(int[,] matrix)
{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
				for (int j = 0; j < matrix.GetLength(0); j++)
				{
						Console.Write($"{matrix[i, j], 4}");
				}
				Console.WriteLine();
		}
}

int FindIndexes(int[,] matrix, int index_row, int index_column) 
{
	if (index_row >= matrix.GetLength(0) || index_column >= matrix.GetLength(1) )
		return -1;
		return matrix[index_row, index_column];
}
		
	


Console.Write("Введите первое значения индекса по строке:");
int index_row = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе значения индекса по столбцу:");
int index_column = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
int a = FindIndexes(matrix, index_row, index_column);
if (a == -1)
Console.WriteLine($"позиция i ={index_row} , j = {index_column} -> такой позиции нет");
else
Console.WriteLine($"позиция i ={index_row} , j = {index_column} -> {a}");
