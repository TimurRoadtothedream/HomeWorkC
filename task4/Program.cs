﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 0;
while (count < N)
{
    count++;
    if (count % 2 == 0)
    Console.WriteLine($"Четные числа:{count}");
}