// Задача 42. Напишите программу которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string DecToBin(int num)
{
  string resNum = string.Empty;
  while (num > 0)
  {
    resNum = num % 2+ resNum;
    num = num / 2;
  }
  return resNum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string decToBin = DecToBin(number);
Console.WriteLine(decToBin);