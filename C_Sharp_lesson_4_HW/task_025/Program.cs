/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int number = DataEntry("Введите любое число: ");
int exponenta = DataEntry("Введите возводимую степень: ");

int DataEntry(string message)
{
    Console.Write(message);
    string inputMessage = Console.ReadLine();
    int inputNumber = int.Parse(inputMessage);
    return inputNumber;
}

int Power(int number, int exponenta)
{
    int result = 1;

    for(int i=1; i <= exponenta; i++)
    {
        result = result * number;
    }
    return result;
}

bool ExponenetaCheck(int exponenta)
{
    if(exponenta > 0)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Степень должна быть больше нуля!");
        return false;
    }
}

if(ExponenetaCheck(exponenta))
{
int expNum = Power(number, exponenta);
Console.WriteLine($"Число {number} в степени {exponenta} равно {expNum}");
}
