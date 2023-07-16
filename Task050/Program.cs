﻿/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
 */




int[,] CreateMatrixRndInt(int rows, int columns, int min = -10, int max = 10)
{
    //                           0      1
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //                                        форматирование строк
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}


int[,] array2d = CreateMatrixRndInt(3, 3, -100, 100);
PrintMatrix(array2d);
Console.WriteLine("введтите (x) :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введтите (y) :");
int y = Convert.ToInt32(Console.ReadLine());

if (x >= array2d.GetLength(0) || y >= array2d.GetLength(0) || x < 0 || y < 0)
{
    Console.WriteLine("такой координаты в массиве нет");
    return;
}
Console.WriteLine($"-->{array2d[x, y]}");