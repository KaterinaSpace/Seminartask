// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. 
//  Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();
int a = ReadNuumberFromConsole("Введите длину стороны А");
int b = ReadNuumberFromConsole("Введите длину стороны В");
int c = ReadNuumberFromConsole("Введите длину стороны С");

Console.WriteLine($"A={a}, B={b}, C={c}");

bool isTriangleExists = IsTriangleExists(a, b, c);
if (isTriangleExists)
  Console.WriteLine("Треугольник существует");
else
  Console.WriteLine("Треугольник не существует");


int ReadNuumberFromConsole(string message = "")
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}

bool IsTriangleExists(int a, int b, int c)
{
  // if (a + b < c || b + c < a || c + a < b)
  //   return false;
  // else
  //   return true;

  if (a + b < c)
    return false;
  else if (b + c < a)
    return false;
  else if (c + a < b)
    return false;
  else
    return true;
}