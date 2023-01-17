/* Задача 10: Напишите программу, которая 
1. принимает на вход трёхзначное число и 
2/ на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number *(-1);
if (number < 100 || number > 999) Console.WriteLine("Вы ввели не трехзначное число!!!");
else 
{
  int result = SecondNumber(number);
  Console.WriteLine(result);
}
int SecondNumber (int num)
{
  int number1 = number / 10;
  int number2 = number1 % 10;
  return number2;
}

