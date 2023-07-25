/* Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт сумму натуральных элементов в промежутке
  от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



Console.WriteLine("введите первое натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNaturaleNumbers(number1, number2));


// int SumDigits(int num1,int num2)// 453/10= 45 /10 =4 /10 =0
// {   
//     if (num2 == 0) return 0;
//     return num1 + SumDigits(num1,num2-1);
// }

int SumNaturaleNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        return num2 + SumNaturaleNumbers(num1, num2 - 1);
    }
    else if (num1 > num2)
    {
         return num2 + SumNaturaleNumbers(num1, num2 + 1);
    }
    else
    {
       return num1;
    }
}