//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. 
//Например, задан массив: 
//1 4 7 2 
//5 9 2 3 
//8 4 2 4 
//1 7 -> такого числа в массиве нет 
//1 1 -> 9

Console.Write("Введите позицию искомого элемента. Строку и столбец церез пробел: "); 
string[] str = Console.ReadLine().Split(' '); // заведение элементов в массив из строки 
int line = Convert.ToInt32(str[0]); 
int column = Convert.ToInt32(str[1]);

int[,] FillArray() 
{ 
int[,] array = new int[5, 4]; 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        array[i, j] = new Random().Next(0, 10);  
    } 
     
} 
return array; 
}

int ElementSearch(int[,] array) 
{ 
int count = 0; 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        if (i == line && j == column) count = array[i, j]; 
        //else Console.WriteLine($"{line} {column} -> такого числа в массиве нет"); 
     
    } 
     
} 
return count; 
}

void PrintArray(int[,] array) 
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

void PrintCount(int count) 
{ 
    if (count == 0) Console.WriteLine($"{line} {column} -> такого числа в массиве нет"); 
    else Console.WriteLine($"{line} {column} -> {count}"); 
}

int[,] array = FillArray(); 
PrintArray(array); 
Console.WriteLine(); 
int count = ElementSearch(array); 
PrintCount(count);