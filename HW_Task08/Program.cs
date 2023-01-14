/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Пример:
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите натуральное число!");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (count == 1)
{
  count++;
}
if (number < 0)
{
  Console.WriteLine("Введено не натуральное число!");
}
else
{
  while (count <= number)
  {
    Console.Write($"{count} ");
    count+=2;
  }
}