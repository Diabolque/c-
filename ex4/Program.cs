//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа через пробел:");
string input = Console.ReadLine();
string[] numbers = input.Split(' ');
Console.WriteLine("Введеные числа: {0} {1} {2}", numbers[0], numbers[1], numbers[2]);
if ((int.Parse(numbers[0]) > int.Parse(numbers[1])) && (int.Parse(numbers[0]) > int.Parse(numbers[2])))
    Console.WriteLine("Наибольшее число: {0}", numbers[0]);
else if ((int.Parse(numbers[1]) > int.Parse(numbers[0])) && (int.Parse(numbers[1]) > int.Parse(numbers[2])))
    Console.WriteLine("Наибольшее число: {0}", numbers[1]);
else
    Console.WriteLine("Наибольшее число: {0}", numbers[2]);
    