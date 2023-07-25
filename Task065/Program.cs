/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */



Console.WriteLine("введите первое натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturaleNumbers(number1, number2);

/* void NaturaleNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturaleNumbers(num1 + 1, num2);

    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturaleNumbers(num1 - 1, num2);

    }
    else
    {
        Console.Write($"{num1} ");
    }
}
*/

void NaturaleNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        NaturaleNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num1 > num2)
    {
        NaturaleNumbers(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    else
    {
        Console.Write($"{num2} ");
    }
}