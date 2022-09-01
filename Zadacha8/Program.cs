//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите любое число N: ");

int number1 = int.Parse(Console.ReadLine());
int count = 2;

while (count <= number1)
{
  if (count % 2 == 0)
    Console.Write(count + ",");

 count = count + 1;
}