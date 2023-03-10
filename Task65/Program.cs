// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void NaturalNumbers(int m, int n)
{
  Console.Write($"{m} ");
  if (m == n) return;
  if (m > n)
  {
    // Console.Write($"{m} ");
    NaturalNumbers(m - 1, n);
  }
  else
  {
    // Console.Write($"{m} ");
    NaturalNumbers(m + 1, n);
  }
}

Console.WriteLine("Введите начальное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1<0 || number2<0) Console.WriteLine("Введите натуральные числа");
else NaturalNumbers(number1, number2);