/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

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
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}
Console.WriteLine("введтите (m) :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введтите (n) :");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(m,n,-100,100);
PrintMatrix(array2d);