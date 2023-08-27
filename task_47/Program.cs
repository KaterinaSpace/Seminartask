// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] MassNums(int rows, int columns, int min, int max)
{
    double[,] arr = new double[rows, columns];

    for (int i = 0; i < arr.GetLength(0); i++ )
{ 
        for (int j = 0; j < arr.GetLength(1); j++)
        
          {  
            arr[i, j] = New Random().Next(min, max+1 )/ 10.0;
          }
            return arr; 
    
}
}

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{arr[i, j], 4}");
            Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Enter the number of rows:");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns:");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive:");
int minNum = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive:");
int maxNum = int.Parse(Console.ReadLine()!);

double[,] matrix = MassNums(row_num, column_num, minNum, maxNum);
Print(matrix);



