// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число М:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

if (m < n)
{
    SumNumbers(m, n);
    Console.WriteLine($"M = {m}; N = {n} -> {SumNumbers(m, n)}");
}
else
{
    SumNumbers(n, m);
    Console.WriteLine($"M = {m}; N = {n} -> {SumNumbers(n, m)}");
}

int SumNumbers(int num1, int num2)
{
    if (num1 == num2)
        return num1;
    {
        return (num1 + SumNumbers(num1 + 1, num2));
    }
}
