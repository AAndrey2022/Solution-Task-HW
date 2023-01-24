﻿// / Напишите программу, которая:
// - принимает на вход трёхзначное число 
// - и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (-99 <= num && num <= 99 || -999 <= num && num > 999)
    Console.Write("Введено некорректное значение! Введите трехзначное число!");
else
    Console.Write($"Вторая цифра числа: {num / 10 % 10} ");
