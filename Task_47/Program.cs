// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9 
// 8 7,8 -7,1 9

Console.Write("Задайте размер массива. Количество строк: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Задайте размер массива. Количество столбцов: "); 
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArray(array); // вызовы функции array должны быть после создания самого массива. Это же так логично) иначе, ДО этого их не существует. 
PrintArray(array);

void FillArray(double[,] array) 
{ 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        array[i, j] = (new Random().NextDouble()*10 -5); // умножаем на 10, что бы появилась цифра перед запятой и отнимаем 5, что бы получить отрицательные числа 
    } 
} 
}

void PrintArray(double[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            // Console.Write($"{array[i, j]} "); 
            Console.Write($"{Math.Round(array[i, j], 2)} "); 
        } 
        Console.WriteLine(); 
    } 
}

// Console.WriteLine(Math.Round(num,2)); 
// Console.Write("\t" + Math.Round(a[i, j], 2));