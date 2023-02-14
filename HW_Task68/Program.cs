// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkermanFunction(int m, int n)
{

  if (m == 0) return n + 1;
  if (n == 0) return AkermanFunction(m - 1, 1);
  return AkermanFunction(m - 1, AkermanFunction(m, n - 1));
}

Console.Write("Введите натуральное число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN < 0 || numM < 0) Console.WriteLine("Вы ввели отрицательное число!");
else
{
  int akerman = AkermanFunction(numM, numN);
  Console.Write($"m = {numM}, n = {numN} -> A({numM},{numN}) = {akerman}");
}