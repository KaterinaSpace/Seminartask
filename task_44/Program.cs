// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358

int n = ReadNumberFromConsole("Введите сколько чисел фибоначи надо вывести");
int[] fibArray = GetFibNumbers(n);
PrintArray(fibArray);

void PrintArray(int[] array)
{
  Console.Write("{");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write(array[i] + ",");
  }
  Console.WriteLine(array[array.Length - 1] + "}");
}

int[] GetFibNumbers(int n)
{
  int[] result = new int[n];
  
  if (n >= 2)
    result[1] = 1;

  for (int i = 2; i < result.Length; i++)
  {
    result[i] = result[i - 1] + result[i - 2];
  }
  return result;
}

  int ReadNumberFromConsole(string message = "")
  {
    if (message != "")
      Console.WriteLine(message);
    string input = Console.ReadLine();
    return int.Parse(input);
  }