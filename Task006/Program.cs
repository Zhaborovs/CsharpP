/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
 */

 Console.WriteLine("введите целочисленное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if(0 == number1 % 2){Console.WriteLine($" {number1} является четным числом. ");}
else {Console.WriteLine($" {number1} не является целочислиным или четным числом. ");}
