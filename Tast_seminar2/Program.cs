﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
// Нахождение через int
Console.Write("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine()??" ");

// нахождение первой и послежней цифры
int num1 = (num / 10000);
int num2 = (num % 10);
// нахождение второй и предпоследней цифры
int twonum1 = (num / 1000) %10;
int twonum2 = (num % 100) / 10;

if (num >= 10000 && num <= 99999)
{
// Console.WriteLine(num1);
// Console.WriteLine(num2);
// Console.WriteLine(twonum1);
// Console.WriteLine(twonum2);
    if (num1 == num2 || twonum1 == twonum2) Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет");
}
else Console.WriteLine("Ну чего ты, не можешь ввести пять цифр подряд?");
*/

/*
// ПРИМЕР обращение к элементу строки
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
string num1 = Convert.ToString(num);
Console.WriteLine("{0}{1}",num1[0],num1[2]);

string Myarray(int count, string text)
*/


/*
Console.WriteLine("Введите координаты точки один: ");
string[] array1 = Console.ReadLine()
*/


Console.Write("Введите число: ");
string[] array = Console.ReadLine()

if (array[0] == array[1])
{
Console.WriteLine("работет")
}
