// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int num1, int num2)
{
  int result = 1;
  for (int i = 0; i < num2; i++)
  {
    result = result * num1;
  }
  return result;
}

Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 < 0) Console.WriteLine("Введите натуральное число В!");
else
{
  int pow = Pow(number1, number2);
  Console.WriteLine($"Число {number1} в {number2} степени = {pow}");
}