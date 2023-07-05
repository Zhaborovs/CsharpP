/* 
Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
 */



string Quarter(int x)
{
    if (x == 1) return "x > 0, y > 0";
    if (x == 2) return "x < 0, y > 0";
    if (x == 3) return "x < 0, y < 0";
    if (x == 4) return "x > 0, y < 0";
    return null; //возвращаем пустое значение
}

Console.WriteLine("Введите номер четверти от 1 до 4");
Console.Write("четверть: ");
int x = Convert.ToInt32(Console.ReadLine());
string quarter = Quarter(x);
string result = quarter == null
    ? "введены некоректные данные"
    : $"значения четверти {quarter}";
Console.WriteLine(result);

