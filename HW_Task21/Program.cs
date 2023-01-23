// Напишите программу, которая принимает 
// на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double GetCoordinates(int ax, int ay, int az, int bx, int by, int bz)
{
  double res = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
  return res;
}

Console.Write("Введите AX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите AY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите AZ: ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите BX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите BY: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите BZ: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double result = GetCoordinates(aX, aY, aZ, bX, bY, bZ);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.Write($"Растояние между точками: {resultRound}");