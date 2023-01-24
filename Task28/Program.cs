// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Factor(int num)
{
  int factor = 1;
  for (int i = 1; i <= num; i++)
  {
    factor *= i;
  }
  return factor;
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Не корректный ввод!");
else
{
  int factorial = Factor(number);
  Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
}