// Напишите программу, которая:
// - принимает на вход число 
// - и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

int summNumbers = SummNumbers(num);
Console.Write($"Сумма цифр числа {num} -> {summNumbers}");
int SummNumbers(int number)
{
    if (number > 0)
        while (number > 0)
        {
            count = count + number % 10;
            number = number / 10;
        }

    while (number < 0)
    {
        count = count - number % 10;
        number = number / 10;
    }
    return count;
}



