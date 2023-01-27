// Напишите программу, которая:
// - принимает на вход пятизначное число 
// - и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// string palindromNum = PalindromNum(num);

// string PalindromNum(int number)
// {
//     int num1 = number / 10000;
//     int num2 = number % 10;
//     int num3 = number / 10000;
//     int num4 = number % 10;
//     string res = "Да, является палиндромом";
//     if (num1 == num2 && num3 == num4) return res;
//     string res1 = "Нет, не является палиндромом";
//     if (num1 != num2 || num3 != num4) return res1;
// }
// Console.Write($"Число {num} {palindromNum}");

int num1 = num / 10000;
int num2 = num % 10;
int num3 = num / 10000;
int num4 = num % 10;
if (num1 % num2==0 && num3 % num4==0)
    Console.Write($"Число {num} является палиндромом");
else
{
 if (num1 != num2 || num3 != num4)
 Console.Write($"Число {num} не является палиндромом");
}
