

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

int[] MatrixMinElemindex(int[,] matrix)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[row, column])
            {
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column };
}

int[,] DeletRowColumnElem(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == row) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == column) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}










int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] matrixMinElemindex = MatrixMinElemindex(array2d);
Console.WriteLine();

int[,] newArray2d = DeletRowColumnElem(array2d,matrixMinElemindex[0],matrixMinElemindex[1]);
PrintMatrix(newArray2d);