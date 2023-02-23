// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 

Console.Write("Задайте размер массива. Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте размер массива. Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];


FillArray(array); 
PrintArray(array);
Console.WriteLine();
SortingArray(array);
PrintArray(array);
void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100); 
       
    }
}
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
void SortingArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}