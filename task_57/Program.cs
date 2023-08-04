//задача 57:  Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int rows = 3;
int columns = 4;
int minRandom = 1;
int maxRandom = 9;

int[,] mass = FillArrayRandomInt(rows, columns, minRandom, maxRandom);
PrintMatrix(mass);
int[] arr = MatrixToArray(mass);
PrintArray(arr);
Console.WriteLine();
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();
FreqDictionary(arr);

void FreqDictionary(int[] array)
{
  int countFr = 1;
  int currentNum = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] == currentNum)
    {
      countFr++;
    }
    else
    {
      Console.WriteLine($" число {currentNum} встречается {countFr} раз");
      currentNum = array[i];
      countFr = 1;
    }
  }
  Console.WriteLine($" число {currentNum} встречается {countFr} раз");
}


int[] MatrixToArray(int[,] array)
{
  int[] collection = new int[array.Length]; //=new int[rows*columns]
  int count = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      collection[count] = array[i, j];
      count++;
    }
  }
  return collection;
}


int[,] FillArrayRandomInt(int rowsArray, int columnArray, int min, int max)
{
  int[,] arrayRandom = new int[rowsArray, columnArray];
  for (int i = 0; i < rowsArray; i++)
  {
    for (int j = 0; j < columnArray; j++)
    {
      arrayRandom[i, j] = new Random().Next(min, max);
    }
  }
  return arrayRandom;
}

void PrintMatrix(int[,] prMatrix)
{
  for (int i = 0; i < prMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < prMatrix.GetLength(1); j++)
    {
      Console.Write($"{prMatrix[i, j],4}");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

void PrintArray(int[] prArray)
{
  for (int i = 0; i < prArray.Length; i++)
  {
    System.Console.Write($"{prArray[i]}, ");
  }
}