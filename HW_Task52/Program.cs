// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
  int[,] matrix = new int[rows, colums];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
      else Console.Write($"{matrix[i, j],3}");
    }
    Console.WriteLine("|");
  }
}

int [] ElementsAverage(int[,] matrix)
{
  int size = matrix.GetLength(0);
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    int[] sum = new int [matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum[i] += matrix[i, j];
    }
    //Console.Write($"{Math.Round((sum / size),1)} | ");
    return sum;
  }
}

// void PrintArray(int[] sum)
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     Console.Write($"{arr[i]}");
//     if (i < arr.Length-1) Console.Write(", ");
//   }
// }

int[,] array2D = CreateMatrixRndInt(4, 10, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] elementsAverage = ElementsAverage(array2D);
Console.Write(elementsAverage);