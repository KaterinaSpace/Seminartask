// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12    (подсказка: остаток деления от 10)


Console.WriteLine("Введите число ");
int inputInt = GetInput();
int len = DigitLen(inputInt);
int SumDigits = CountSum(inputInt, len);
Console.WriteLine($"Сумма всех цифр в числе равна:{SumDigits}");

//функция ввода
int GetInput()
{
    string input = Console.ReadLine()!;
    int result = int.Parse(input);
    return result;
}


//Функция подсчета цифр в числе

    int DigitLen(int a)
    {
        int Count = 0;
        while(a > 0)
        {
            a /= 10;
            Count++;
        }
        return Count;
    }



//Фукция вывода суммы цифр в числе
int CountSum(int n, int lenght)
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}