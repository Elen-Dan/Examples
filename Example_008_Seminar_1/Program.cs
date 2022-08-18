// Создаем переменную 
double a;
string? input;
double result;
// Вводим число
Console.WriteLine("Введите число: ");
input = Console.ReadLine();
// C# convert string to int
a = double.Parse(input);
// Возводим в квадрат
result = a * a;
// Вывод результата
Console.WriteLine("Результат: " + result);
Console.WriteLine(a * a);

