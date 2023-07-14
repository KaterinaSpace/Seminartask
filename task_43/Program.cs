// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
 
//variant 1, любое количнство раз

int count = CountNum();
Console.WriteLine($"Количество чисел больше 0: {count}");

int CountNum()
{
  int count = 0; 
  string word;


  while (true)
  {
    Console.Write("Введите любое число:");
    word = Console.ReadLine();

    if (word == "") return count;
    else if (int.Parse(word) > 0) count += 1;
  }
}

//variant 2,заранее знаем сколко будет значении от пользователя

Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = checked(a);
Console.WriteLine($"Количество чисел больше 0: {result}");

int check(int num)
{
  int count = 0;
  {
    Console.Write($"Число{i}:");
    int a = int.Parse(Console.ReadLine()!);
    if (a > 0) count++;
  }
  return count; 
}





