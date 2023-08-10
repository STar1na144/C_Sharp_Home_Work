// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int day = new Random().Next(1, 15);
Console.WriteLine("День недели: " + day);

if(day > 0 && day <= 7)
{
    if(day > 5 && day <= 7)
    {
        Console.WriteLine("Выходной.");
    }
    else
    {
        Console.WriteLine("Рабочий.");
    }
}
else
{
    Console.WriteLine("Это не день недели.");
}