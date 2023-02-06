// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

bool OutputElement(int[,] matrix, int row, int colum)
{
  if (matrix.GetLength(0) < row || matrix.GetLength(1) < colum) return false;
  else return true;
}

Console.Write("Введите позицию строки: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int columPosition = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine(OutputElement(array2D,rowPosition,columPosition) 
? $"Значения элемента = {array2D[rowPosition-1,columPosition-1]}" 
: "Nакого элемента в массиве нет");