/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */


/* int FactorialRec(int n)
{
if (n == 1) return 1;
else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10)); // 3628800 */



Console.WriteLine("введите первое натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number1));

int SumDigits(int num)// 453/10= 45 /10 =4 /10 =0
{
    if (num % 10 == 0) return 0;//0
    return num % 10 + SumDigits(num / 10);
}