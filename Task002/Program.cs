/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее. */
Console.WriteLine("введите целочисленное число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите целочисленное число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine($"число {number1} равно числу {number2}.");
}
else if(number1 > number2)
{
    Console.WriteLine($"число {number1} больше числа {number2}.");
}
else
{
   Console.WriteLine($"число {number1} меньше числа {number2}.");
}