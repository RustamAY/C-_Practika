/* 16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
bool result = Square(firstNumber, secondNumber);

bool Square(int num1, int num2)
{
  return num1 * num1 == secondNumber || num2 * num2 == firstNumber;
}

//if (result == true) Console.WriteLine("Да");
//else Console.WriteLine("Нет");

Console.WriteLine(result ? "да" : "нет");






/*
int MultipleNum(int num1, int num2)
{
    int square = num1 * num1;
    return square;
}
int MultipleNum2(int num1, int num2)
{
    int square = num2 * num2;
    return square;
}
Console.WriteLine("Введите два числа :");


int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int result = MultipleNum(number1, number2);
int result2 = MultipleNum2(number1, number2);

if (number1 < number2)
{
    if (result == number2)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    if (result2 == number1)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}




bool Square(int number1, int number2)
{
    return ((number1 * number1 == number2) || (number2 * number2 == number1));
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

if (result == true) Console.WriteLine("да");
else Console.WriteLine("нет");
*/