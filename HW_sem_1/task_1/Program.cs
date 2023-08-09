//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.WriteLine("Первое число больше = " + a + " Второе число = " + b);
} else if (a == b) {
    Console.WriteLine("Все числа равны = " + a + " Первое число = " + a + " Второе число = " + b);
} else {
    Console.WriteLine("Второе число больше = " + b + " Первое число = " + a);
}