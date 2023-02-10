// Задача 58: 
// 1. Задайте две матрицы. 
// 2. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int mult = default;
      for (int k = 0; k < result.GetLength(0); k++)
      {
        mult += matrix1[i, k] * matrix2[k, j];
      }
      result[i, j] = mult;
    }
  }
}

int[,] firstArray2D = CreateMatrixRndInt(3, 2, 1, 10);
PrintMatrix(firstArray2D);
Console.WriteLine();
int[,] secondArray2D = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(secondArray2D);
if (firstArray2D.GetLength(1) > secondArray2D.GetLength(0)) Console.Write("Произведение матриц не возможно!");
else
{
  int[,] resultMatrix = new int[2, 2];
  Console.WriteLine("Результирующая матрица будет:");
  MultiplyMatrix(firstArray2D, secondArray2D, resultMatrix);
  PrintMatrix(resultMatrix);
}
