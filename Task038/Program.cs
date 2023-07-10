/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76  */



double[] CreateArrayRndDouble(int size, int min = -10, int max = 10)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ", ", int round = 1)
{
for (int i = 0; i < arr.Length; i++)
{
double num = Math.Round(arr[i], round);
if (i < arr.Length - 1) Console.Write($"{num}{sep}");
else Console.Write($"{num}");
}
}

double CountNumbers(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max > arr[i]) max =arr[i];
        if (min < arr[i]) max =arr[i];
    }
    
    return max-min;
}

double[] array = CreateArrayRndDouble(4, -10, 10);
double result = CountNumbers(array);
Console.Write($"[");
PrintArrayDouble(array);
Console.WriteLine($"]");
Console.WriteLine($"разницу между максимальным и минимальным элементов массива = {Math.Round(result, 1)}");