﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов* и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// *В заданном пользльзователем диапазоне

var rand = new Random();
Console.WriteLine("Введите диапазон от 0 до: ");
int a = int.Parse(Console.ReadLine()??"");
int[] array = new int[8];
Console.Write("["); // первая скобка
for (int i = 0; i < 8; i++)
{
    Console.Write($"{rand.Next(0, a)}, "); // рандомный генератор от 0 до "a"
}
Console.Write("\b\b"); // обрезание пробела и последней запятой
Console.WriteLine("]"); // последняя скобка