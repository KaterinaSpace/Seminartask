// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
array[0] = new Random().Next(0, 2);
array[1] = new Random().Next(0, 2);
array[2] = new Random().Next(0, 2);
array[3] = new Random().Next(0, 2);
array[4] = new Random().Next(0, 2);
array[5] = new Random().Next(0, 2);
array[6] = new Random().Next(0, 2);
array[7] = new Random().Next(0, 2);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "");
    }
}
PrintArray(array);