// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int decNumber = ReadNumberFromConsole("Введите десятичное число");
Console.WriteLine(DecToInt(decNumber));


string DecToInt(int decimalNumber)
{
  string result = string.Empty; //тоже самое, что и ""
  while (decimalNumber >  0)
  {
    result = $"{decimalNumber % 2}" + result;
    decimalNumber /= 2;
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

