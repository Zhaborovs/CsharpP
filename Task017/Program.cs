﻿/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

/*
 if (xCoordinate > 0 && yCoordinate > 0) Console.WriteLine($"x {xCoordinate} y {yCoordinate} Это 1я - четворть");
else if (xCoordinate < 0 && yCoordinate > 0) Console.WriteLine($"x {xCoordinate} y {yCoordinate} Это 2я - четворть");
else if (xCoordinate < 0 && yCoordinate < 0) Console.WriteLine($"x {xCoordinate} y {yCoordinate} Это 3я - четворть");
else if (xCoordinate > 0 && yCoordinate < 0) Console.WriteLine($"x {xCoordinate} y {yCoordinate} Это 4я - четворть");
else Console.WriteLine("Введены некоректные координаты (0)");
 */



int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
int quarter = Quarter(xCoordinate, yCoordinate);
if (quarter == 0) Console.WriteLine("ошибка ввода");
else Console.WriteLine($"x: {xCoordinate} y: {yCoordinate} Это {quarter}я - четворть");
