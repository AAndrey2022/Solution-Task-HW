// Задача 66: 
// - Задайте значения M и N. 
// - Напишите программу, которая найдёт сумму натуральных элементов 
//   в промежутке от M до N. 
//   Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите первое значение: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int summNuberSeries = SummNuberSeries(number, number1);

Console.Write($"M = {number}; N = {number1} -> {summNuberSeries}, ");

int SummNuberSeries(int num, int num1)
{
    if (num == num1) return num;
    else
    if (num < num1)
    {
        SummNuberSeries(num + 1, num1);
        return num + SummNuberSeries(num + 1, num1);
    }
    else
    if (num > num1)
        SummNuberSeries(num - 1, num1);
    return num + SummNuberSeries(num - 1, num1);
}
// if (number < 0 || number1 < 0)
//  Console.WriteLine("Введено некорректное значение введите число от 1 до бесконечности: ");
