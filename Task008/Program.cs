// Напишите программу, которая:
// - на вход принимает число (N), 
// - а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
 if (num < 0)
 Console.Write("Не корректный ввод, Введите Натуральное (Положительное!) число: ");
 else
 while (count < num)
  { 
    Console.Write($" {count},");
    count += 2;
  }

