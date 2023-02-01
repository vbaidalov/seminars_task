// Задача 34:  Задайте массив заполненный случайными положительными трёхзначными  числами. Напишите программу, которая покажет количество чётных чисел в  массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[4];
MyRandomArray(array);
Console.Write(" -> "); // наводим красоту
Console.WriteLine(Positive(array));


void MyRandomArray(int[] array) // функция создания рандомного массива
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(100, 999);
     Console.Write(array[i] + ", ");
}
Console.Write("\b\b");
Console.Write("]");
}
int Positive(int[] array) // функция поиска чётного числа в массиве
{
     int count = 0;
for (int i = 0; i < array.Length; i++)
     {     
     if (array[i] % 2 == 0)
     count++;
     }
     return count;
}