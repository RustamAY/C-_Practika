//0. Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Insert a integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Square of {number} is {square}");