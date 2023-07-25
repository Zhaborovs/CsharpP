/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5,  */


Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
NaturaleNumbers(number);

void NaturaleNumbers(int num)
{
    if(num==0)return;
    NaturaleNumbers (num-1);
    Console.Write($"{num} ");
}