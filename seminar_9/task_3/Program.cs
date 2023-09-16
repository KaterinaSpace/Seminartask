// Задача 2:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M и N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8; -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

string PrintNumbers(int m, int n)
{
    if (m == n)
        return m.ToString(); //почему тустринг
    return (m + ", " + PrintNumbers(m + 1, n));
}
