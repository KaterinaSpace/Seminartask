//Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// A = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0123
// 1234
// 2345





int[,] MassNums(int row, int column)
{
  int[,] arr = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = i + j;
  return arr;
}

void Print(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      Console.Write($" {arr[i, j],4} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num);
Print(mass);