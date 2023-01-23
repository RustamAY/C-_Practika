// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double GetCoordinates(int ax, int ay, int bx, int by)
{
  double res = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
  return res;
}

Console.Write("Введите AX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите AY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите BX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите BY: ");
int bY = Convert.ToInt32(Console.ReadLine());

double result = GetCoordinates(aX, aY, bX, bY);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.Write($"Растояние между точками: {resultRound}");

// double d = 5.09997623455;
// double dRuynd = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRuynd);
// Math.Pow (2, 10); - возведение в степень возврашает doubl
// Math.Sqrt(5); - извлечение корня возврашает doubl
// Math.Round(d, 2, MidpointRounding.ToZero) - округление до второго знака