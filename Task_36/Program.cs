// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
MyRandomArray(array);
Console.Write(" -> ");
Console.WriteLine(FindEvenNumbers(array));

void MyRandomArray(int[] array) 
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(-100, 100);
     Console.Write(array[i] + ", ");
}
Console.Write("\b\b");
Console.Write("]");
}
int FindEvenNumbers(int[] array)
{
int EvenNumbers = 0;
for (int i = 1; i < array.Length; i++)
{
    EvenNumbers = EvenNumbers + array[i];
    i++; 
}
return EvenNumbers;
}