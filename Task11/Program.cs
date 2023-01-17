/* 11. Напишите программу, которая 
1. выводит случайное трёхзначное число и 
2. удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
int result = RemoveTheSecond(number);
int RemoveTheSecond(int num)
{
  int firstDigit = number / 100;
  int thirdDigit = number % 10;
  int numberResult = (firstDigit*10) + thirdDigit;
  return numberResult;
}
Console.WriteLine($"первое и последнее число => {result}");

/* работа в группе
int number = new Random().Next(100, 999);
Console.WriteLine($"Трехзначное число {number}");
int RemoveTheSecond(int num)
{
    int numberFirst = num / 100; // 4.56 4
    int numberThird = num % 10;
    int numberResult = numberFirst * 10 + numberThird;
    return numberResult;
}
Console.WriteLine(RemoveTheSecond(number));
*/