/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)//перебераем строки
    {
        for (int g = 0; g < matrix.GetLength(1)-1; g++)//перебераем столбци
        {
            for (int l = 0; l < matrix.GetLength(1) - g - 1; l++)
            {
                if (matrix[i, l] < matrix[i, l + 1]) //стрелкаой указываем направление сортировки
                {
                    int temp = matrix[i, l];
                    matrix[i, l] = matrix[i, l + 1];
                    matrix[i, l + 1] = temp;
                }
            }
        }
    }
}


int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
SortMatrix(array2d);
Console.WriteLine();
PrintMatrix(array2d);
