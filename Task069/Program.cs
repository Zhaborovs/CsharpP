/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */


Console.WriteLine("введите натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень натурального числа:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowDigits(number1,number2));

int PowDigits(int num1,int num2)// 453/10= 45 /10 =4 /10 =0
{
    if (num2 == 0) return 1;
    return num1 * PowDigits(num1,num2-1);
}