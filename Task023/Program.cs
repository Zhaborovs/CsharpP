/* 
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
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
        Console.WriteLine($"{count, 3}^3 = {count * count* count, 5}");
        count++;
    }
}