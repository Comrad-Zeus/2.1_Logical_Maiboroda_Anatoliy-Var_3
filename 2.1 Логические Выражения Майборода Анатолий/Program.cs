// Логические выражения - 3 вариант - Высокий уровень

Console.WriteLine("Введите X: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
double y = double.Parse(Console.ReadLine());
if (y >= 0 && y <= -x * x + 2) Console.WriteLine("Принадлежит");
else Console.WriteLine("Мимо");