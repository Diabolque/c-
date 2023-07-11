//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("введите два числа");

int x = int.Parse(Console.ReadLine());

Console.WriteLine("первое число "+x);

int y = int.Parse(Console.ReadLine());

Console.WriteLine("второе число "+y);

if(x>y){
    Console.WriteLine("первое число больше второго");
}
else{
    Console.WriteLine("второе число больше первого");
}
