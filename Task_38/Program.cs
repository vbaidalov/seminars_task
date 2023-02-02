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
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
} 
int result = max - min; 
return result; 
}