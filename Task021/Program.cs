/* 
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */






Console.WriteLine("Введите координаты точки 1");
Console.Write("1X: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("1Y: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("1Z: ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2");
Console.Write("2X: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2Y: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("2Z: ");
int b3 = Convert.ToInt32(Console.ReadLine());


double result = Distance(a1, a2, b1, b2, a3, b3);
//                     окр. число. после запятой. стратегия
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"растояние между точками {resultRound}");

double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    int katet1 = x1 - x2;
    int katet2 = y1 - y2;
    int katet3 = z1 - z2;
    double dist = Math.Sqrt(katet1 * katet1 + katet2 * katet2 + katet3 * katet3);
    return dist;
}