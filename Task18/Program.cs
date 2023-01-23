// Задача 18: Напишите программу, которая 
// по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

string Coordinate(string num)
{
  // if (num == 1) return "x>0, y>0";
  // if (num == 2) return "x<0, y>0";
  // if (num == 3) return "x<0, y<0";
  // if (num == 4) return "x>0, y<0";
  // return "Введены не корректные координаты!";

  switch (num)
{
  case "1": return "Допустимые координаты: x > 0 и y > 0";
  case "2": return "Допустимые координаты: x < 0 и y > 0";
  case "3": return "Допустимые координаты: x < 0 и y < 0";
  case "4": return "Допустимые координаты: x > 0 и y < 0";
  default: return "Введены некорректные координаты";
}
}

Console.Write("Введите номер четверти: ");
string number = Console.ReadLine();
string result = Coordinate($"{number}");
Console.WriteLine(result);
