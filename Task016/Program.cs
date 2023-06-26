/* 16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.WriteLine("введите первое число");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int secondDigit = Convert.ToInt32(Console.ReadLine());

 //                  логический оператор (или) две вертикальные черты
if (firstDigit * firstDigit == secondDigit || secondDigit * secondDigit == firstDigit)Console.WriteLine("одно число является квадратом другого");
else Console.WriteLine("ни одно число не является квадратом другого");