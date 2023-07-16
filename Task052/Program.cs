/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] MathMatrix(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    double temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            temp += matrix[j, i];

        }
        result[i] = temp /  matrix.GetLength(0);
        
    }  
    return result;
}
void PrintArray(double[] arr, string sep = ",  ")
{

    for (int i = 0; i < arr.Length; i++)
    {
    
        if (i < arr.Length - 1)
        {
            Console.Write($"{Math.Round(arr[i])}{sep}");
        }
        else
        {
            Console.Write($"{Math.Round(arr[i])}");
        }
    }
}


int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2d);
Console.WriteLine("среднее арифметическое по столбцам ->");
PrintArray(MathMatrix(array2d));