// Задача 19

// Напишите программу, которая 
// принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Polindrom(int num)
{
  int first = num / 10000;
  int second = (num / 1000) % 10;
  int fourth = (num % 100) / 10;
  int fifth = num % 10;
  return first == fifth && second == fourth;
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 9999 || number >= 100000) Console.WriteLine("Число не пятизначное или не натуральное!");
else
{
  bool result = Polindrom(number);
  Console.WriteLine(result ? "Да": "Нет");
}


// else
// {
//   int first = number /10000;
//   Console.WriteLine($"{number}  -> {first}");
//   int second = (number / 1000)%10;
//   Console.WriteLine($"{number}  -> {second}");
//   int fourth = (number%100)/10;
//   Console.WriteLine($"{number}  -> {fourth}");
//   int fifth = number%10;
//   Console.WriteLine($"{number}  -> {fifth}");
//   if (first == fifth || second == fourth) Console.WriteLine("Да");
//   else Console.WriteLine("Нет");
// }