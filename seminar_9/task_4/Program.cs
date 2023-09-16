// **Задача 3: ** Напишите программу, которая  на вход принимает два числа А и В, и возводит А в целую степень В с помощью рекурсии.
// А = 3; В = 5 -> 243 (3 в пятой степени)
// А = 2; b = 3 -> 8


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень: ");
int range = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{Pow(number, range)}");

int Pow(int number, int range)
{
    if (range == 0)
        return 1;
    if (range == 1)
        return number;
    return (number * Pow(number, range - 1));
}
