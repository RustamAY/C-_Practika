// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Factorial(int n) { // 1! = 1 // 0! = 1 
// if(n == 1) return 1; 
// else return n * Factorial(n-1); } Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6

int SumDigits(int num1, int num2)
{
  return num2 == 0 ? 1 : num1 * SumDigits(num1, num2 - 1);
}

Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(number1, number2);
Console.WriteLine(sumDigits);