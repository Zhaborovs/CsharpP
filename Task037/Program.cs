/* 
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

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

int[] ProductPairNumber(int[] arr)
{

    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        if (i == arr.Length - 1 - i)
        {
            newArr[i] = arr[i];
            return newArr;
        }
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return newArr;
}

int[] array = CreateArrayRndInt(6, 1, 9);
Console.Write($"[");
PrintArray(array);
Console.WriteLine($"]");
Console.Write($"--->");
int[] newArray = ProductPairNumber(array);
PrintArray(newArray);