// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool CheckingWeekend(int day)
{
  return day == 6 || day == 7;
}

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
//bool result = CheckingWeekend(dayNumber);

if (dayNumber < 1 || dayNumber > 7) Console.WriteLine ("Вы ввели неправильную цифру!");
else Console.WriteLine(/*result*/CheckingWeekend(dayNumber) ? "Да" : "Нет");