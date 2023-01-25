// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите первый координат Ax: "); 
int ax = int.Parse(Console.ReadLine()??" "); // ??" " позволяет убрать ошибку 
Console.Write("Введите второй координат Ay: "); 
int ay = int.Parse(Console.ReadLine()??" "); 
Console.Write("Введите третий координат Az: "); 
int az = int.Parse(Console.ReadLine()??" "); 
Console.Write("Введите первый координат Bx: "); 
int bx = int.Parse(Console.ReadLine()??" "); 
Console.Write("Введите второй координат By: "); 
int by = int.Parse(Console.ReadLine()??" "); 
Console.Write("Введите второй координат Bz: "); 
int bz = int.Parse(Console.ReadLine()??" ");

double result = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)), 3); 
Console.Write($" A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> {result}");