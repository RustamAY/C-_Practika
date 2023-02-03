/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double FindX(double b1, double k1, double b2, double k2)
{
  double x = Math.Round(((b2 - b1) / (k1 - k2)), 1);
  return x;
}

double FindY(double b2, double k2, double x)
{
  double y = Math.Round((k2 * x + b2), 1);
  return y;
}


Console.Write("Введите число для b1: ");
double numB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для k1: ");
double numK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для b2: ");
double numB2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для k2: ");
double numK2 = Convert.ToInt32(Console.ReadLine());

if (numK1==numK2) {Console.WriteLine($"Прямые y = {numK1} * x + {numB1}, y = {numK2} * x + {numB2} паралельны друг другу!");}
else if (numK1==numK2 && numB1==numB2) {Console.WriteLine($"Прямые y = {numK1} * x + {numB1}, y = {numK2} * x + {numB2} совпадают");}
else
{
double x = FindX(numB1, numK1, numB2, numK2);
double y = FindY(numB2, numK2, x);
Console.Write($"({x}; {y})");
}