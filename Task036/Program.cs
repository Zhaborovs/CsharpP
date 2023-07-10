/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        if (0 != i % 2)
        {
            count += arr[i] ;
        }
    }
    return count;
}

int[] array = CreateArrayRndInt(4, -100, 100);
int result = CountNumbers(array);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");
Console.WriteLine("-->");
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях = {result}");