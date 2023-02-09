// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
// {
//   int[,] matrix = new int[rows, colums];
//   Random rnd = new Random();
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = rnd.Next(min, max + 1);
//     }
//   }
//   return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     Console.Write("|");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
//       else Console.Write($"{matrix[i, j],3}");
//     }
//     Console.WriteLine("|");
//   }
// }

// int[] MatrixToArray(int[,] matrix)
// {
//   int[] result = new int[matrix.Length];
//   int count = default;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       result[count++] = matrix[i, j];
//     }
//   }
//   return result;
// }

// void PrinntArray(int[] arr)
// {
//   Console.Write("[");
//   for (int i = 0; i < arr.Length; i++)
//   {
//     if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//     else Console.Write(arr[i]);
//   }
//   Console.WriteLine("]");
// }

// void GetSameNumberCount(int[] arr)
// {
//   int tmp = arr[0];
//   int count = 1;
//   for (int i = 1; i < arr.Length; i++)
//   {
//     if (tmp == arr[i]) count++;
//     else
//     {
//       Console.WriteLine($"{tmp} - {count}");
//       arr[0] = arr[i];
//       count = 1;
//     }
//   }
//   Console.WriteLine($"{tmp} - {count}");
// }


// int[,] array2D = CreateMatrixRndInt(3, 3, 0, 10);
// PrintMatrix(array2D);
// int[] array = MatrixToArray(array2D);
// Array.Sort(array);
// PrinntArray(array);
// GetSameNumberCount(array);


int[,] GenerateMatrix(int rows, int columns, int min, int max) 
{ 
    int[,] matrix = new int[rows, columns]; 
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
 
string PrintMatrix(int[,] matrix) 
{ 
    string str = string.Empty; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        str += "["; 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} "; 
            else str += $" {matrix[i, j],3}, "; 
        } 
        str += "]\n"; 
    } 
    return str; 
 
} 
 
int[] MatrixToArray(int[,] matrix) 
{ 
    int[] result = new int[matrix.Length]; 
    int count = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            result[count++] = matrix[i, j]; 
        } 
    } 
    return result; 
} 
 
string PrintArray(int[] arr) 
{ 
    string str = String.Empty; 
    for (int i = 0; i < arr.Length; i++) 
    { 
        str += $"{arr[i]} "; 
    } 
    return str; 
 
} 
 
void GetSameCountNubers(int[] arr) 
{ 
    int tmp = arr[0]; 
    int count = 1; 
    for (int i = 1; i < arr.Length; i++) 
    { 
        if (tmp == arr[i]) count++; 
        else 
        { 
            Console.WriteLine($"{tmp} - {count}"); 
            tmp = arr[i]; 
            count = 1; 
        } 
    } 
    Console.WriteLine($"{tmp} - {count}"); 
} 
 
int[,] matrixNumbers = GenerateMatrix(3, 4, 0, 10); 
Console.WriteLine(PrintMatrix(matrixNumbers)); 
 
int[] array = MatrixToArray(matrixNumbers); 
Array.Sort(array); 
Console.WriteLine(PrintArray(array)); 
 
 
GetSameCountNubers(array);

