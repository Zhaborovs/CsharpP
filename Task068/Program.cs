/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/


Console.WriteLine("введите натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе натуральноге число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("число должно быть положительное");
    return;
}

Console.WriteLine(AkkermanDigitsF(number1, number2));

int AkkermanDigitsF(int num1, int num2)// 453/10= 45 /10 =4 /10 =0
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return AkkermanDigitsF(num1 - 1, 1);
    return AkkermanDigitsF(num1 - 1, AkkermanDigitsF(num1, num2 - 1));
}