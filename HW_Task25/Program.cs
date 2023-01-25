// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int numA, int numB)
{
  int result = 1;
  for (int i = 1; i <= numB; i++)
  {
    result = result * numA;
  }
  return result;
}

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 0) Console.WriteLine("Введите натуральное число В!");
else
{
  int pow = Pow(numberA, numberB);
  Console.WriteLine($"Число {numberA} в {numberB} степени = {pow}");
}