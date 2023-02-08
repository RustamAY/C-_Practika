// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReplaceMatrix(int[,] matrix)
{
  int[,] tmpArray = new int[matrix.GetLength(0), matrix.GetLength(1)];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int tmp = matrix[i, j];
      tmpArray[j, i] = matrix[i, j];
      matrix[i, j] = tmp;
    }
  }
  return tmpArray;
}


int[,] array2D = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
if (array2D.GetLength(0) == array2D.GetLength(1))
{
int[,] newMatrix = ReplaceMatrix (array2D);
PrintMatrix(newMatrix);
}
else Console.WriteLine("Число строк и столбцов не совпадает!");