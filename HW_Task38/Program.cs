// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
  double[] array = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
  }
  return array;
}

void PrinntArrayDouble(double[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write(array[i]);
  }
  Console.Write("]");
}

double FindMaxElemet(double[]array)
{
  double max =array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if(max < array[i]) max=array[i];
  }
  return max;
}

double FindMinElemet(double[]array)
{
  double min =array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if(min > array[i]) min=array[i];
  }
  return min;
}

double DifferenceMaxMin(double max, double min)
{
  double diff = Math.Round((max - min),2);
  return diff;
}

double[] arr = CreateArrayRndDouble(5, 1, 50);
PrinntArrayDouble(arr);
double maximum = FindMaxElemet(arr);
double minimum = FindMinElemet(arr);
double diff = DifferenceMaxMin(maximum, minimum);
Console.WriteLine($" -> {diff}");

// Нахождение max, min элементов массива и разницу между ними в одном методе
// double FindDiffMaxMinElemets(double[]array)
// {
//   double max =array[0];
//   double min = array[0];
//   double dif = 0;
//   for (int i = 1; i < array.Length; i++)
//   {
//     if(max < array[i]) max=array[i];
//     else if (min>array[i]) min=array[i];
//     dif = Math.Round((max-min),2);
//   }
//   return dif;
// }

// double[] arr = CreateArrayRndDouble(5, 1, 50);
// PrinntArrayDouble(arr);
// double diff = FindDiffMaxMinElemets(arr);
// Console.WriteLine($" -> {diff}");
