/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int DataEntry(string message)
{
    Console.Write(message);
    string inputMessage = Console.ReadLine();
    int inputNumber = int.Parse(inputMessage);
    return inputNumber;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();

    for(int i = 0; i < Length;i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Минимальнве значение в массиве: ");
int max = DataEntry("Максимальное значение в массиве: ");
int[] array = GenerateArray(length, min, max);

PrintArray(array);