//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) { Console.WriteLine("Первое число максимальное = " + a);
} else if (b > a && b > c) { Console.WriteLine("Второе число максимальное = " + b);
} else if (c > a && c > b) { Console.WriteLine("Третье число максимальное = " + c);
} else if (a == b && a == c) { Console.WriteLine("Все числа равны = " + a + " Первое число = " + a + " Второе число = " + b + " Третье число = " + c );
} else if (a == b && a > c) { Console.WriteLine("первое и второе число равны = " + a + " Третье число = " + c );
} else if (a == c && a > b) { Console.WriteLine("первое и третье число равны = " + a  + " Второе число = " + b);
} else { Console.WriteLine("второе и третье число равны = " + b + " Первое число = " + a);
}