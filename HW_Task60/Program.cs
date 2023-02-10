// *Задача 60. 
// 1. Сформируйте трёхмерный массив из 
// 2. неповторяющихся двузначных чисел. 
// 3. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int colums, int depth, int min, int max)
{
  int[,,] matrix = new int[rows, colums, depth];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        matrix[i, j, k] = rnd.Next(min, max + 1);
      }

    }
  }
  return matrix;
}

void PrintMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        if (j < matrix.GetLength(1)) Console.Write($"{matrix[i, j, k],3} ({i},{j},{k}) | ");
        else Console.WriteLine($"{matrix[i, j, k],3} ");
      }
      
    }
    Console.WriteLine("");
  }
}
int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10, 99);
PrintMatrix(array3D);