// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] MassNums(int row, int column, double from, double to)
// {
//   int[,] arr = new int[row, column];
//   for (i = 0; i < row; i++)
//     for (j = 0; j < column; j++)
//     arr[i , j] = new Random().NextDouble(from, to + 1);
//   return arr;
// }

// void Print(double[,] arr) 
// {
//   int row = arr.GetLength(0);
//   int column= arr.GetLength(1);

//   for(i = 0; i < row; i++ )
//   {
//     for (j = 0; j < column; j++)
//     Console.Write($"{arr[i,j], 4}");
//     Console.WriteLine(); 
//   }
//   Console.WriteLine();
// }

// Console.Write("Enter the number for rows:");
// int row_num = int.Parse(Console.ReadLIne()!);
// Console.Wrtite("Enter the number for columns:");
// int column_num = int.Parse(Console.ReadLine()!);

// Console.Write("Enter the min number of massive:");
// double start = double.Parse(Console.REadLIne()!);
// Console.Write("Enter the max number of massive:");
// double stop = double.Parse(Console.ReadLine()!);

// double[,] mass = MassNums(row_num, column_num, start, stop);
// Print(mass);




