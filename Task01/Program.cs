// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Inser number a:");
int a = Convert.ToInt32(Console.ReadLine()); //25
Console.WriteLine("Inser number b:");
int b = Convert.ToInt32(Console.ReadLine()); // 2
int square = b * b;
if (a == square)
{
  Console.WriteLine($"Number {a} is square of {b}");
}
else
{
  Console.WriteLine($"Number {a} is not square of {b}");
}