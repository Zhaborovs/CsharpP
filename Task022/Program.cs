/* 
Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
 */

Console.WriteLine("введите целочисленное положительное число");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 0)
{
    TableSquare(x);
}
else Console.WriteLine($"ошибка ввода!");



void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3}^2 = {count * count, 5}");
        count++;
    }
}