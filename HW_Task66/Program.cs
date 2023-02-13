// Задача 66: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// 3. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumOfNaturalNumbers(int numM, int numN)
{ 
  return numM == numN ? numM : SumOfNaturalNumbers(numM + 1, numN) + numM;
}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > numberN)
{
  int temp = numberM;
  numberM = numberN;
  numberN = temp;
}
if (numberM < 0 || numberN < 0) Console.WriteLine("Вы ввели отрицательное число!");
else
{
  int sum = SumOfNaturalNumbers(numberM, numberN);
  Console.Write($"M = {numberM}; N = {numberN} -> {sum}");
}