/* 7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2


918 -> 8 */

Console.WriteLine("введите целое трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}

if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"последняя цифра этого числа:{lastDigit}");
}
else
{
    Console.WriteLine($"ошибка ввода : {number} не я вляется трехзначным числом");
}
