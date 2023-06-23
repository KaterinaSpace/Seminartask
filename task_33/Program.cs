// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] array = { 6, 7, 19, 345, 3 };
Console.WriteLine("Введите число, котрое надо найти");
int number = ReadNumberFromConsole();
bool result = FindNumberInArray(array, number);
if (result == true)
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}


bool FindNumberInArray(int[] array, int numberToSearch)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == numberToSearch)
    {
      return true;
    }
  }
  return false;
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

int ReadNumberFromConsole()
{
  string input = Console.ReadLine();
  return int.Parse(input);
}