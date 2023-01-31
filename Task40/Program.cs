// Задача 40. Напишите программу, которая, принимает на вход три числа
// и проверяет, может, ли со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

bool CheckTringle (int side1, int side2, int side3)
{
  return side1<(side2+side3) && side2<(side1+side3) && side3<(side1+side2);
}

Console.Write("Введите первую сторону треугольника: ");
int firstSide = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую сторону треугольника: ");
int secondSide = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью сторону треугольника: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());
bool result = CheckTringle(firstSide, secondSide, thirdSide);
Console.WriteLine (result ? "Да" : "Нет");