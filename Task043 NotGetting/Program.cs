/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


Console.WriteLine("введите 1е число 1го отрезка:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2е число 1го отрезка:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 1е число 2го отрезка:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2е число 2го отрезка:");
int k2 = Convert.ToInt32(Console.ReadLine());

if(k1=k2)
