// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(min, max + 1);
  }
  return array;
}

void PrinntArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write(array[i]);
  }
  Console.WriteLine("]");
}

int GetSumNegativeElem(int[] array)
{
  int sum = default;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 0) sum += array[i];
  }
  return sum;
}

int GetSumPositivElem(int[] array)
{
  int sum = default;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) sum += array[i];
  }
  return sum;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrinntArray(arr);
int getSumNegativeElem = GetSumNegativeElem(arr);
int getSumPositivElem = GetSumPositivElem(arr);
Console.WriteLine($"Сумма положительных чисел равна: {getSumPositivElem}");
Console.WriteLine($"Сумма отрицательных равна: {getSumNegativeElem}");

// нахождение суммы отрицательных и положитеьных в одном методе

// int[] GetSumPositiveNegativeElem(int[] array)
// {
//     int sumNegative = 0;
//     int sumPositive = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sumPositive += array[i];
//         if(array[i] < 0) sumNegative += array[i];
//     }
//     return new int[]{sumPositive, sumNegative};
// }

// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");