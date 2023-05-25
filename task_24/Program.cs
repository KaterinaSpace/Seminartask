//Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//<тип_возвращаемого_значения> <название_функции> (<>параметры)
//{
//    
//}

Console.WriteLine("Введите число А");
int inputInt = GetInput();
int sum = SumFrom1ToA(inputInt);
Console.WriteLine(sum);

int GetInput()
{
  string input = Console.ReadLine();
  int result = int.Parse(input);
  return result;
}

int SumFrom1ToA(int a)
{
  int sum = 0;
  for (int i = 0; i <= a; i++)
  {
    sum += i; //  sum = sum + 1 
  }
  return sum; 
}