/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число не кратно
второму, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.WriteLine("введите первое число");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int result = firstDigit % secondDigit;

if(result == 0)Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток {result}");


