﻿/* 9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

int number = new Random().Next(10, 100);// 99+1
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");


int firstDigit = number / 10;
int secondDigit = number % 10;

/* if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
}
else if (firstDigit < secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа {secondDigit}");
}
else
{
    Console.WriteLine("цифры одинаковы");
} */


//  тернарный оператор ( вопрос )   ( тогда )    ( если не )
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {maxDigit}");

//  сразу выводим результат
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit );
