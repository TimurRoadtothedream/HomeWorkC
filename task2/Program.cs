// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Узнаем какое из трех чисел большее. Введите 1 число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное число: {max}");