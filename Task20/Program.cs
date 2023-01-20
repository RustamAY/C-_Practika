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
Console.Write($"Растояние между точками: {result}");


// Console.WriteLine("введите координаты первой точки ");
// Console.Write("X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите координаты второй точки ");
// Console.Write("X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(x1, y1, x2, y2);
// double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
// Console.WriteLine($"Расстояние между точками {distanceRound}");


// double Distance(int xc1, int yc1, int xc2, int yc2)
// {
//     return Math.Sqrt(Math.Pow((xc2 - xc1), 2) + Math.Pow((yc2 - yc1), 2));
// }