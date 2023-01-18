/// Напишите программу, которая:
// 1. На вход принимает два числа 
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// 2.выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} Max");
}
if (num1 < num2)
{
  Console.WriteLine($"Число {num2} Max");  
}
if (num1 == num2)
{
 Console.WriteLine($"Числа равны");   
}