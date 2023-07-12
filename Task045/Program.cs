/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */

int[] array = CreateArrayRndInt(5, 100, 1000);
int[] result = CopirateMassive(array);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");
Console.WriteLine("-->");
Console.Write($"[");
PrintArray(result);
Console.WriteLine($"]");

int[] CopirateMassive(int[] arr)
{
int[] newArr = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    newArr[i]=arr[i];
}
return newArr;
}


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







