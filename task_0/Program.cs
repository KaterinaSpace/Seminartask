// 0. Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.




int[,] MassNums(int row, int column, int from, int to)
{
  int[,] arr = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = new Random().Next(from, to + 1);
  return arr;
}

void Print(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);


  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      Console.Write($" {arr[i, j], 4} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.Write("Enter the number of rows:");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns:");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass =MassNums(row_num, column_num, start, stop);
Print(mass);

