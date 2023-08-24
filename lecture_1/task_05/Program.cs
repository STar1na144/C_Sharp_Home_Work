Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура я угадал");
}
else
{
    Console.Write("Привет, " + username);
}