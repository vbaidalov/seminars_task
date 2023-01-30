// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12

Console.WriteLine("Введите число: "); 
int a = int.Parse(Console.ReadLine()??""); 
int TotalSum(int a) 
{ 
    int sum = 0; 
    for (int i = 0; a > 0; i++) 
    { 
        sum = sum + a % 10; 
        a = a / 10; 
    } 
    return sum; 
} 
Console.WriteLine($"{a} -> {TotalSum(a)}");
