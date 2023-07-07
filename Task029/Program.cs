/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

 */




Console.WriteLine("Введите целое положительное число (колл-во элементов массива):");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число (предел случайного числа массива):");
int rand = Convert.ToInt32(Console.ReadLine());

int[] arrayNums = new int[number];

arrayNums[4] = 231;

Massive(arrayNums, rand);
printArray(arrayNums);

void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i == arr.Length - 1)
        {
            Console.Write("]");
        }
        else
        {
            Console.Write(",");
        }
    }
}

void Massive(int[] arr, int limit)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        checked
        {
            arr[i] = rnd.Next(limit) + 1;
        }
    }
}