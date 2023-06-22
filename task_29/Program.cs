// Задача 29: Напишите программу, которая приниматет на вход длину массива, 
//минимальное значение массива и максимальное значение массива, создаёт массив
// с заданными параметрами и выводит значения на экран

// 5, 1, 19 -> [1, 2, 5, 7, 19]

// 3, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива");
int n = ReadNumberFromConsole();
int[] array = new int[n];

Console.WriteLine("Введите миимальное значение элемента массива");
int min = ReadNumberFromConsole();
Console.WriteLine("Введите максимальное значение элемента массива");
int max = ReadNumberFromConsole();


FillArray(array, min, max);
PrintArray(array);
int ReadNumberFromConsole()
{
  string input = Console.ReadLine();
  return int.Parse(input);
}

void PrintArray(int[] array)
{
  Console.Write("{");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]},");
  }
  Console.WriteLine(array[^1] + "}");
}

void FillArray(int[] array, int min, int max)
{
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(min, max);
  }
}