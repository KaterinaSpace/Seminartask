// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int rows = 3;
int columns = 4;
int minRandom = -9;
int maxRandom = 9;

int[,] mass = FillArrayRandomInt(rows, columns, minRandom, maxRandom);

PrintArray(mass);
ReplaceArray(mass);
PrintArray(mass);

void ReplaceArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(1); i++)
  {
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
  }
}

int[,] FillArrayRandomInt(int rowsArray, int columnsArray, int min, int max)
{
  int[,] arrayRandom = new int[rowsArray, columnsArray];
  for (int i = 0; i < rowsArray; i++)
  {
    for (int j = 0; j < columnsArray; j++)
    {
      arrayRandom[i, j] = new Random().Next(min, max);
    }
  }
  return arrayRandom;
}

void PrintArray(int[,] PrArray)
{
  for (int i = 0; i < PrArray.GetLength(0); i++)
  {
    for (int j = 0; j < PrArray.GetLength(1); j++)
    {
      Console.Write($"{PrArray[i, j],4}");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}
