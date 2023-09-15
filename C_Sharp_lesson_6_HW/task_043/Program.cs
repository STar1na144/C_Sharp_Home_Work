/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int InputNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

double b1 = InputNumber("Введите b1: ");
double k1 = InputNumber("Введите k1: ");
double b2 = InputNumber("Введите b2: ");
double k2 = InputNumber("Введите k2: ");

double x = (b1-b2)/(k2-k1);
double y = k2*(b1-b2)/(k2-k1) + b2;

Console.WriteLine($"Координаты точки пересечения прямых: ({x}; {y})");