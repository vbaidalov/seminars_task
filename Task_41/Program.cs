// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());


int[] GetArray(int n)
{
int[] array = new int [n];
for (int i = 0; i < array.Length; i++)
    {
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int[] array = GetArray(n);

int CounterNegativeNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) count++;
    }
    return count;
}


void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i]);
    Console.Write(", ");
    }
Console.Write("\b\b ");

}

PrintArray(array);
Console.Write(" -> ");
Console.Write(CounterNegativeNumbers(array));