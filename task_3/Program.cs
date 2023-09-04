//  3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.






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

int SumDiag(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                count = count + array[i, j];
            }
        }
    }
    return count;
}

Console.Write("Enter the number of rows:");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns:");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

Console.WriteLine(SumDiag(mass));


// int[,] MassNum(int row, int column, int from, int to)
// {
// int[,] arr = new int[row, column];

// for (int i = 0; i < row; i++)
// for (int j = 0; j < column; j++)
// arr[i, j] = new Random().Next(from, to + 1);
// return arr;
// }

// void Print(int[,] arr)
// {
// int row = arr.GetLength(0);
// int column = arr.GetLength(1);

// for (int i = 0; i < row; i++)
// {
// for (int j = 0; j < column; j++)
// Console.Write($" {arr[i, j],4} ");
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// int GeneralDiagonal(int[,] arr)
// {
// int row = arr.GetLength(0);
// int column = arr.GetLength(1);
// int sum = 0;

// if (row > column) row = column;
// for (int i = 0; i < row; i++)
// sum += arr[i, i];
// return sum;
// }

// Console.Clear();
// Console.Write("Enter the number of rows: ");
// int row_num = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the number of columns: ");
// int column_num = int.Parse(Console.ReadLine()!);

// Console.Write("Enter the min number of massive ");
// int start = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the max number of massive ");
// int stop = int.Parse(Console.ReadLine()!);

// int[,] mass =MassNums(row_num, column_num, start, stop);
// Print(mass);

// Console.WriteLine($"{GeneralDiagonal( mass)}");
