﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] GetArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] result = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                while (true)
                {
                    int randomValue = new Random().Next(minValue, maxValue + 1);
                    if (!FindValue(result, randomValue)) //! логический оператор нет, то выводит то что внизу результат
                    {
                        result[i, j, k] = randomValue;
                        break;
                    }
                }
            }
        }
    }
    return result;
}

bool FindValue(int[,,] array, int value)
{
    bool checkValue = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value)
                {
                    checkValue = true;
                    break;
                }
            }
        }
    }
    return checkValue;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})   ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = GetArray(2, 2, 2, 10, 99);
PrintArray(array);
Console.WriteLine();
