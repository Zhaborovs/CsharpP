/* 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
 */


Console.WriteLine("введите пятизначное, целочисленное и положительное число");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0) x = x * -1;
if (x > 9999 && x < 100000)
{
    if (true == Polidrom(x))
    {
        Console.WriteLine($"число {x} является палиндромом");
    }
    else
    {
        Console.WriteLine($"число {x} не является палиндромом");
    }

}
else Console.WriteLine($"ошибка ввода!");

bool Polidrom(int num)
{
    if (num / 10000 == num % 10)
    {
        if ((num / 1000 % 10) == (num % 100 / 10))
        {
            return true;
        }
        Console.WriteLine($"2е цифры не сходятся {num / 1000 % 10} и {num % 100 / 10}");
        return false;
    }
    Console.WriteLine($"1е цифры не сходятся {num / 10000} и {num % 10}");
    return false;
}