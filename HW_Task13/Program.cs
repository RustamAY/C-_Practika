/* Задача 13: Напишите программу, которая 
1. выводит третью цифру заданного числа или 
2. сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

// Метод когда пользователь вводит число

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int addedNumber = number;
if (number < 0) number = number * (-1);
if (number < 100) Console.Write($"{addedNumber} -> третьей цифры нет");
else Console.Write($"{addedNumber} -> {ThirdNumber(number)}");
int ThirdNumber(int num)
{
  
  while (num > 1000)
  {
    num /= 10;
  }
  return num % 10;
}

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int addedNumber = number;
// int result = ThirdNumber(number);
// if (addedNumber < 100)
//   Console.Write($"{addedNumber} -> третьей цифры нет");
// else
//   Console.Write($"{addedNumber} -> {result}");
// int ThirdNumber(int num)
// {

//   while (number > 1000)
//   {
//     int div = number / 10;
//     number = div;
//   }
//   return number % 10;
// }