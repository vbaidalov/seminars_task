// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива. 
// [3 7 22 2 78] -> 76 
int[] array = new int[5]; 
MyRandomArray(array); 
Console.Write(" -> "); 
Console.WriteLine(FindingMinMax(array));


void MyRandomArray(int[] array) // функция создания рандомного массива 
{ 
Console.Write("["); 
for (int i = 0; i < array.Length; i++) 
{ 
     array[i] = new Random().Next(1, 100); 
     Console.Write(array[i] + ", "); 
} 
Console.Write("\b\b"); 
Console.Write("]"); 
}


int FindingMinMax(int[] array) 
{ 
int max = array[0]; 
int min = array[0]; 
for (int i = 0; i < array.Length; i++) 
{ 
     if (max < array[1]) max = array[1]; 
     if (max < array[2]) max = array[2]; 
     if (max < array[3]) max = array[3]; 
     if (max < array[4]) max = array[4]; 
           
     for (int j = 0; j < array.Length; j++) 
     { 
          if (min > array[1]) min = array[1]; 
          if (min > array[2]) min = array[2]; 
          if (min > array[3]) min = array[3]; 
          if (min > array[4]) min = array[4]; 
           
     } 
} 
int result = max - min; 
return result; 
}