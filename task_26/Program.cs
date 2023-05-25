// Задача 26: Напишите программу, которая 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число A");
int inputNumber = GetInputNumber(); // переменная импут инт присваивается значение 
int amountOfDigits = CountDigits(inputNumber);
Console.WriteLine(amountOfDigits);


int GetInputNumber()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int CountDigits(int a)
{
    int digitsCounter = 0;
    while (a > 0)
    {
        a /= 10;
        digitsCounter++;
    }
    return digitsCounter;
}

