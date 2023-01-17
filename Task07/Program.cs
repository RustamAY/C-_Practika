/*7. Напишите программу, которая принимает на вход трёхзначное число
на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8*/

Console.WriteLine("Введите трехзнаное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1000 || number < 100)
{
  Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
  int lastDigit = number % 10;
  Console.WriteLine($"Последняя цифра: {lastDigit}");
}