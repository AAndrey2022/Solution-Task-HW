// Напишите цикл, который:
// - принимает на вход два числа (A и B) 
// - и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Введите число А: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num1 = Convert.ToInt32(Console.ReadLine());

double digitPowerNumTwo = DigitPowerNumTwo(num, num1);
Console.Write($"{num}, {num1} -> {digitPowerNumTwo}  (Число {num} в степени {num1})");
double DigitPowerNumTwo(int number,int number1)
{
  double res = Math.Pow(number, number1);
  return res;
} 