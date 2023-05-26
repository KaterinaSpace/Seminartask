//Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36
//------------------------
// int[] array = new int[4];
// array[0]=1;
// array[1]=2;
// array[2]=3;
// array[3]=4;

// Console.WriteLine(array.Length);
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + "");
// }


// array[0] = new Random().Next(0, 2);
// array[1] = new Random().Next(0, 2);
// array[2] = new Random().Next(0, 2);
// array[3] = new Random().Next(0, 2);
// // Console.Write("{");
// for (int i = 0; i < array.Length - 1; i++)
// {
// Console.Write($"{array[i]},");
// }
// Console.WriteLine(array[^1] + "}");


//------------------------------------------------

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
    string input = Console.ReadLine()!;
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