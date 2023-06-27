// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов на нечетных позиях = {CalcSum(array)} ");


void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-100, 101);
  }
}

void PrintArray(int[] array)
{
  Console.Write("{");
  for (int i = 0; i < array.Length - 1; i++)      //почему - 1
  {
    Console.Write($"{array[i]},");
  }
  Console.WriteLine(array[^1] + "}");
}

int CalcSum(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0)
    {
      sum += array[i];
    }
  }
  return sum;
}



