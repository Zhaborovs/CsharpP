﻿/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

 */

int[] CreateArrayRndInt(int size, int min = -10, int max = 10)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ", ")
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}{sep}");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
}

int CountNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (0 == arr[i] % 2)
        {
            count += 1;
        }
    }
    return count;
}

int[] array = CreateArrayRndInt(4, -999, 999);
int result = CountNumbers(array);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");
Console.WriteLine("-->");
Console.WriteLine($"количество четных чисел = {result}");
