//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите по очереди три числа, нажимая Enter: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number1 < number2) max = number2;
if (number2 < number3) max = number3;
Console.WriteLine(max + " это максимальное число");
