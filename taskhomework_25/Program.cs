// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число A");
int numA = GetInputNumber();
Console.WriteLine("Введите второе число B");
int numB = GetInputNumber();

var result = ToDegree(numA, numB);
Console.WriteLine(result);

int GetInputNumber()
{
  string input = Console.ReadLine();
  return int.Parse(input);
}

// void ToDegree(int a, int b)
// {
//   int result = 1;
//   for (int i = 1; i <= b; i++)
//   {
//     result = result * a;

//   }
//   Console.WriteLine(result);
// }

int ToDegree (int a, int b)
{
  int result = 1;
  for (int i = 1; i <= b; i++)
  {
    result = result * a;
  }
  return result; 
}
