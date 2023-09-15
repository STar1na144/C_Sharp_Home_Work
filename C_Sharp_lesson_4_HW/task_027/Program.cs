/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int number = DataEnter("Введите любое целое число: ");

int DataEnter(string message)
{
    Console.Write(message);
    string inputString = Console.ReadLine();
    int inputNum = int.Parse(inputString);
    return inputNum; 
}

int SummDigits(int number)
{

    int result = 0;

    while(number > 0)
    {
        result = result + number%10;
        number = number/10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр этого числа равна {SummDigits(number)}");
