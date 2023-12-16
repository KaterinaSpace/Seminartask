// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.Clear();
Console.Write("Введите неотрицательное число M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число число N: ");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine(
    $"Функция Аккермана для чисел A({numberM},{numberN}) = {AkkermanFunc(numberM, numberN)}"
);
