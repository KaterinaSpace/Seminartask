// 2. Задайте двумерный массив. Найдите элементы,
// у которых обе позиции чётные, и замените эти элементы на их квадраты.
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
Console.Write($" {arr[i, j],4} ");
Console.WriteLine();
}
Console.WriteLine();
}

void NewArr(int[,] arr)
{
int row = arr.GetLength(0);
int column = arr.GetLength(1);

for (int i = 1; i < row; i += 2)
{
for (int j = 1; j < column; j += 2)
{
arr[i, j] *= arr[i, j];
}
}
}


Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, s tart, stop);
Print(mass);
NewArr(mass);
Print(mass);