/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число (степень):");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree <= 0)
{
    Console.WriteLine("ошибка ввода");
    return;
}
int result = cube(number, degree);


Console.WriteLine($"{result}  ({number}^{degree})");




int cube(int x, int y)
{
    int z = 1;
    
    for (int i = 0; i < y; i++)
    {
        checked
        {
         z = z * x;   
        }
    }

    return z;
}






