﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine()??"");


int Step(int num)
{
    int count = 0;
    for (int i = 0; i < b; i++)
    {
    count = i * i;
    }
    return count;
}
Console.WriteLine($"Сумма чисел от 1 до {A} равна {Step(num)}");
