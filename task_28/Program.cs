// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число ");
int inputInt = GetIntInput();
Console.WriteLine(MultNumb(inputInt));

int GetIntInput()
{ 
  string input = Console.ReadLine();
  int result = int.Parse(input);
  return result;
}

int MultNumb(int number)
{
  int sum=1; 
  for(int i = 1; i<= number; i++)
  {
    sum*=i; 
  }
  return sum; 
}