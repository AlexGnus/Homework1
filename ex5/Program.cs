Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, МАША, привет!!");
}
else
{
    Console.WriteLine("Привет: ");
    Console.WriteLine(username);
}
