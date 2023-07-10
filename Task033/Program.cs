/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

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

bool FindNumb(int[] arr, int x)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            return true;
        }
    }
    return false;
}


Console.WriteLine("введите целое число для поиска");
int result = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(5, -9, 9);
bool fN = FindNumb(array, result);
Console.Write($"[");
PrintArray(array);
Console.Write($"]");
Console.Write("--->");
Console.Write(fN ? "Присутствует" : "Отсутствует");