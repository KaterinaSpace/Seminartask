// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[10];
FillArray(array);
PrintArray(array);
double min, max = FindMinMaxNumb(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна  {DiffNumb(array, min, max)} ");


void FillArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-100, 101);
  }
}

void PrintArray(double[] array)
{
  Console.Write("{");
  for (int i = 0; i < array.Length - 1; i++)     
  {
    Console.Write($"{array[i]},");
  }
  Console.WriteLine(array[^1] + "}");
}


double FindMinMaxNumb(double[] array)
{
  max = array[0];
  min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > max)
    {
      max = array[i];
    }

    if (array[i] < min)
    {
      min = array[i];
    }
  }
  Console.WriteLine($"max={max}, min={min}");
  return max;
  return min;

}

double DiffNumb(double[] array, double min, double max)
{

  double sum = min + max;
  return sum;
}



