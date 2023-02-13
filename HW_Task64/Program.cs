// 1. Задача 64: Задайте значение N. 
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// 3. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbers(int num)
{
  if (num == 0) return;
  Console.Write($"{num}");
  if (num > 1) Console.Write(", ");
  NaturalNumbers(num - 1);

}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Вы вели отрицательное число!");
else
{
  Console.Write($"N= {number} -> ");
  NaturalNumbers(number);
}