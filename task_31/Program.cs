//: Задайте массив из 12 элементов, заполненны случайными чслами из промежутка [-9, 9]. Найдте сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9, -8,1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, сумма отрицательных равна - 20. 



int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма положительных чисел = {CalcPositiveSum(array)} ");
Console.WriteLine($"Сумма отрицательных чисел = {CalcNegativeSum(array)} ");

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-9, 10);
  }
}

void PrintArray(int[] array)
{
  Console.Write("{");
  for (int i = 0; i < array.Length-1; i++)      //почему - 1
  {
    Console.Write($"{array[i]},");
  }
  Console.WriteLine(array[^1] + "}");
}

int CalcPositiveSum(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
  if(array[i] > 0)
  {
    sum += array[i]; // sum = sum + arra[i]
  }
  }
return sum;
}

int CalcNegativeSum(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
  if(array[i] < 0)
  {
    sum += array[i]; // sum = sum + arra[i]
  }
  }
return sum;
}