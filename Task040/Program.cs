/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник со сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

Console.WriteLine("ведите длину 1й стороный");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите длину 2й стороный");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите длину 3й стороный");
int side3 = Convert.ToInt32(Console.ReadLine());


bool isExistsTriangle = IsExistsTriangle(side1,side2,side3);

Console.WriteLine(isExistsTriangle?"существует":"не существует");

bool IsExistsTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}