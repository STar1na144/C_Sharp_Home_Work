/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int InputNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

int CountPositiveNumber(int[] array)
{
    int count = default;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

int index = InputNumber("Укажите какое количество чисел планируете ввести: ");
int[] arr = new int[index];

for(index = 0; index < arr.Length; index++)
{
    arr[index] = InputNumber($"Введите {index + 1} число: ");
}

PrintArray(arr);
int res = CountPositiveNumber(arr);
if(res == 0)
{
    Console.WriteLine($"Вы не ввели чисел больше нуля.");
}
else if(res == 1)
{
   Console.WriteLine($"Вы ввели {res} число больше нуля.");
}
else if(res > 2 && res < 5)
{
   Console.WriteLine($"Вы ввели {res} числа больше нуля.");
}
else if(res > 4)
{
    Console.WriteLine($"Вы ввели {res} чисел больше нуля.");
}
