﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a <= 999 || a <= -100 && a >= -999) // использую логическое условие И - a больше или равно 100 при этом а меньше или равно 999. на выходе трёхзначное число. далее зеркалю через ИЛИ, что бы попасть и в минусовой ряд.
{
    int result1 = (a / 10);
    int result2 = (result1 % 10);
    //Console.WriteLine(result1);
    Console.WriteLine(result2);
}
else
{
    Console.WriteLine("У тебя не получилось. Попробуй ещё раз. Введи трёхзначное число ");
}