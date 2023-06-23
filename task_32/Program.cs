// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] array = new int[4];
// Array[1] = -4;
// Array[2] = -8;
// Array[3] = -8;
// Array[4] = -2;

int[] array = { -4, -8, 8, 2 };
PrintArray(array);
NewArray(array);
PrintArray(array);

void NewArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = array[i] * -1;
  }
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




