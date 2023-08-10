// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int number = new Random().Next(0, 1000);
Console.Write("Исходное число: ");
Console.WriteLine(number);

if((number / 100 > 0) && (number / 100 < 10))
{
    int secondNum = number % 100;
    secondNum = secondNum / 10;
    Console.Write("Вторая цифра этого числа: " + secondNum);
}
else
{
    Console.WriteLine("Число не трехзначное!");
}