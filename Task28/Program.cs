


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
if (number < 0) Console.WriteLine("Ввели не положительное число!");
else
{
  int factorial = Factor(number);
  Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
}