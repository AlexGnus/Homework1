//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число : ");

int number1 = int.Parse(Console.ReadLine());

if (number1 % 2 == 0)
    Console.Write(number1 + " четное");
else
    Console.Write(number1 + " нечетное");