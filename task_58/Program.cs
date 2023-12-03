// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Write($"{inArray[i,j]:f1} ");

//количество столбцов первой матрицы должно быть равно количеству строк второй матрицы


using System.Text.Json;

int[,] FillArrayRandom(int rowsArray, int columnArray)
{
  int[,] arrayRandom = new int[rowsArray, columnArray];
  for (int i = 0; i < rowsArray; i++)
  {
    for (int j = 0; j < columnArray; j++)
    {
      arrayRandom[i, j] = new Random().Next(1, 5);
    }
  }
  return arrayRandom;
}

void PrintMatrix(int[,] prMatrix)
{
  for (int i = 0; i < prMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < prMatrix.GetLength(1); j++)
    {
      Console.Write($"{prMatrix[i, j],4}");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}



int[,] Multiplication(int[,] array, int[,] secondArray)
{
  int[,] resultArray = new int[array.GetLength(0), secondArray.GetLength(1)];
  if (array.GetLength(1) != secondArray.GetLength(0))
  {
    Console.WriteLine("Перемножение матриц невозможно ");
  }
  else
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < secondArray.GetLength(1); j++)
      {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
          resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
      }
    }
  }
  return resultArray;
}


Console.Write("Введите количество строк 1 матрицы:");
int rowsArray = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы:");
int columnsArray = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк 2 матрицы:");
int rowsSecondArray = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы:");
int columnSecondsArray = int.Parse(Console.ReadLine()!);

int[,] array = FillArrayRandom(rowsArray, columnsArray);
int[,] secondArray = FillArrayRandom(rowsSecondArray, columnSecondsArray);
PrintMatrix(array);
PrintMatrix(secondArray);
int[,] res = Multiplication(array, secondArray);
Console.WriteLine($"Результирующая матрица будет:");
PrintMatrix(res);