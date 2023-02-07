// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Например, задан массив:  
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4  
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3. 
// ВЫВОД будет дабль! вещественные числа 
// Сложность. Как пойти по столбцам 
// Сложность номер два. как правильно разделить 
int[,] array = FillArray(); 
PrintArray(array); 
Console.WriteLine(); 
Console.WriteLine("Среднее арифметическое каждого столбца:"); 
ArithmeticNumber(array); 
int[,] FillArray() // создание массива 
{  
int[,] array = new int[3, 4];  
for (int i = 0; i < array.GetLength(0); i++)  
{  
    for (int j = 0; j < array.GetLength(1); j++)  
    {  
        array[i, j] = new Random().Next(0, 10);   
    }  
      
}  
return array;  
} 
void ArithmeticNumber(int[,] array) 
{ 
double one = 0, two = 0, three = 0, four = 0; 
     for (int i = 0; i < array.GetLength(0); i++) 
     { 
          for (int j = 0; j < array.GetLength(1); j++) 
          { 
               if (j == 0) one = one + array[i, j]; 
               if (j == 1) two = two + array[i, j]; 
               if (j == 2) three = three + array[i, j]; 
               if (j == 3) four = four + array[i, j]; 
          } 
     } 
double oneX = one / 3, twoX = two / 3, threeX = three / 3, fourX = four / 3; 
Console.Write(Math.Round(oneX, 2)); 
Console.Write("; "); 
Console.Write(Math.Round(twoX, 2)); 
Console.Write("; "); 
Console.Write(Math.Round(threeX, 2)); 
Console.Write("; "); 
Console.Write(Math.Round(fourX, 2)); 
Console.Write("."); 
} 
//double result = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)), 3);  
//Console.Write($" A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> {result}"); 
void PrintArray(int[,] array) // печать 
{  
    for (int i = 0; i < array.GetLength(0); i++)  
    {  
         
        for (int j = 0; j < array.GetLength(1); j++)  
        {  
            Console.Write($"{array[i, j], 2} ");  
        }  
        Console.WriteLine();  
    }  
}
