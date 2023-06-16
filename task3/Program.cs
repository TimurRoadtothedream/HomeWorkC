// Является ли число чётным
Console.Write("Посмотрим, является ли число чётным. Введите целое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}

else
{
    Console.WriteLine("Число нечетное");

}  