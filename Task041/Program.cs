/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


Console.WriteLine("введите сколько чисел вы хотети ввести:");
int num = Convert.ToInt32(Console.ReadLine());
int[] temp = NywArrayForNumbs(num);
int result = PositiveNumbsInArray(temp);
Console.WriteLine($"положительных чисел введено:{result}");


int[] NywArrayForNumbs(int numb)
{
    int[] result = new int[numb];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"введите число {i+1} из {numb} :");
        result[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    return result;
}

int PositiveNumbsInArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result ++;
    }
    return result;
}
