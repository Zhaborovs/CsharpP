/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

 Console.WriteLine("введите целочисленное число N ");
int number1 = Convert.ToInt32(Console.ReadLine());
int cout = 0;
while(cout <= number1){
if(0 == cout % 2){Console.WriteLine(cout);}
cout +=2;
}