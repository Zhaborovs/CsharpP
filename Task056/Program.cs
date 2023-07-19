
/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с
 наименьшей суммой элементов: 1 строка
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

int SortMatrixRowSumElem(int[,] matrix)
{
    int temp = 0;
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)//перебераем строки
    {   

        int Sumelem =0;
        for (int g = 0; g < matrix.GetLength(1); g++)//перебераем столбци
        {
            Sumelem += matrix[i,g];
        }
        if(i == 0)temp = Sumelem;
        else if(Sumelem<temp)
        {
            temp = Sumelem;
            result = i;
        }
    }
    return result;
}


int[,] array2d = CreateMatrixRndInt(5, 1, 1, 9);
PrintMatrix(array2d);
int res = SortMatrixRowSumElem(array2d);
Console.WriteLine($"индекс наименьшей строки: {res} ");