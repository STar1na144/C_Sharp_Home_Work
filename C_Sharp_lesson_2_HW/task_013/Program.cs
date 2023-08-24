// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int number = new Random().Next(0, 10000);
Console.WriteLine("Заданное число: " + number);

if(number > 99)
{
    while(number > 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.Write("Третья цифра заданного числа: " + number);
}
else
{
    Console.Write("Третьей цифры нет.");
}