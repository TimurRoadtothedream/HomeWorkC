// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Узнаем какое число большее, а какое меньшее. Введите число А:");
double numberA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
double numberB = double.Parse(Console.ReadLine());
if (numberA > numberB)

{
    Console.WriteLine($"Большее число: {numberA} Меньшее число {numberB}");

}

else

{

    Console.WriteLine($"Большее число: {numberB} Меньшее число {numberA}");
    
}