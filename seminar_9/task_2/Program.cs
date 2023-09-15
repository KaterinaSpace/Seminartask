// задача 1: ** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(Answer(1, number));

//method
string Answer(int start, int end)
{
    if (start == end)
        return start.ToString();
    return (start + ", " + Answer(start + 1, end)); // тут плюсики для какого то вызова действия при string
}
