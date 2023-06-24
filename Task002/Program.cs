/* 3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

Console.WriteLine("введите номер дня недели");
string number = Console.ReadLine();

if (number == "1") { Console.WriteLine($"{number} -> понедельник"); }
else if (number == "2") { Console.WriteLine($"{number} -> вторник"); }
else if (number == "3") { Console.WriteLine($"{number} -> среда"); }
else if (number == "4") { Console.WriteLine($"{number} -> четверг"); }
else if (number == "5") { Console.WriteLine($"{number} -> пятница"); }
else if (number == "6") { Console.WriteLine($"{number} -> субота"); }
else if (number == "7") { Console.WriteLine($"{number} -> воскресенье"); }
else { Console.WriteLine($"{number} -> этого дня недели не существует,введите число от 1 до 7.");}