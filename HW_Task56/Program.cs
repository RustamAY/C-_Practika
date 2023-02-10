// Задача 56: 
// 1. Задайте прямоугольный двумерный массив. 
// 2. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// 3. Программа считает сумму элементов в каждой строке и 
// 4. выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindSmallestSumRowElements(int[,] matrix)
{
  int row = 0;
  int minSum = 0;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    minSum = minSum + matrix[0, i];
  }

  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum = sum + matrix[i, j];
    }
    if (minSum > sum)
    {
      minSum = sum;
      row = i;
    }
  }
  return row+1;
}



int[,] matrix2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix2D);
int findMinSum = FindSmallestSumRowElements(matrix2D);
Console.WriteLine($"Строка с наименьшей суммой элементов - {findMinSum}");