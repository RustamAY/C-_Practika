// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Мое решение
int SqwrTable(int num)
{
  num *= num;
  return num;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Число не натуралное!");
int i = 1;
 while (i <= number)
 {
   Console.WriteLine($"{i, 5}  {SqwrTable(i),5}");
  i++;
 }


// решение с методом void с класса
// Console.WriteLine("Введите натуральное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 1) Console.WriteLine("Некорректный ввод");
// else Table(number);


// void Table(int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         Console.WriteLine($"{count,5}   {count * count,5}");
//         count++;
//     }
// }