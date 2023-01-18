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
int result1 = ThirdNumber(number);
if (addedNumber < 100)
  Console.Write($"{addedNumber} -> третьей цифры нет");
else
  Console.Write($"{addedNumber} -> {result1}");
int ThirdNumber(int num)
{

  while (number > 1000)
  {
    int div = number / 10;
    number = div;

  }
  return number % 10;
}

// Метод когда число выбирается рандомно


// int number = new Random().Next(10, 99999);
// int addedNumber = number;
// int result1 = ThirdNumber(number);
// if (addedNumber < 100)
//   Console.Write($"{addedNumber} -> третьей цифры нет");
// else
//   Console.Write($"{addedNumber} -> {result1}");
// int ThirdNumber(int num)
// {

//   while (number > 1000)
//   {
//     int div = number / 10;
//     number = div;

//   }

//   return number % 10;
// }