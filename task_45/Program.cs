// Задача 45: Напишите программу, которая будет создвать копию заданного массива с помощью поэлементарного копирования.

int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
PrintArray(array);
int[] newArray = IncrementArray(array);
PrintArray(newArray);
PrintArray(array);

void PrintArray(int[] array)
{
  Console.Write("{");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write(array[i] + ",");
  }
  Console.WriteLine(array[array.Length - 1] + "}");
}

int[] WrongCopyAndIncrementArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = array[i] + 1;
  }
  return array;
}

int[] IncrementArray(int[] array)
{
  int[] newArray = new int[array.Length];
  for (int i = 0; i < newArray.Length; i++)
  {
    newArray[i] = array[i] + 1;
  }
  return newArray;
}