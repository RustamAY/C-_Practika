/*
Задача 41: 
1. Пользователь вводит с клавиатуры M чисел. 
2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] CreateArray(int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < size; i++)
  {
    Console.Write("Введите число:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
  return arr;
}

int CheckNumbersAboveZero(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) count++;
  }
  return count;
}

Console.Write("Сколько чисел хотите проверить?: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] print = CreateArray(arrayLength);
int numbers = CheckNumbersAboveZero(print);
Console.Write($"Пользователь ввел {numbers} больше нуля");