﻿/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10 */


Console.WriteLine("введите число для конвертации");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DecToBin(number));

/*
int DecToBin(int numb)
{
    int result = 0;
    int factor = 1;
    while (numb != 0)
    {
        result = result + numb % 2 * factor;
        numb /= 2;
        factor*=10;
    }
    return result;
}
*/

 string DecToBin(int numb)
 {
    string result = string.Empty;
    while (numb != 0)
    {
        result = numb % 2 + result;
        numb /= 2;
    }
    return result;
}