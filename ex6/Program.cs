﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine("Введенное число: {0}", number);
if (number % 2 == 0)
    Console.WriteLine("Число {0} четное", number);
else
    Console.WriteLine("Число {0} нечетное", number);
    