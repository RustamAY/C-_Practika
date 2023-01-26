// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int num)
{
  int counter = num;
  int advance = 0;
  int result = 0;
  for (int i = 0; i < counter; i++)
  {
    advance = num - num % 10;
    result = result + (num - advance);
    num = num / 10;
  }
  return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
Console.WriteLine(SumNumber(number));