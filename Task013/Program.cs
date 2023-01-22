// Напишите программу, которая:
// - выводит третью цифру заданного числа 
// - или сообщает, что третьей цифры нет. 
// - Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
// int num3=Convert.ToInt32(Console.ReadLine());;
if (num <= 100)
    Console.Write("Третьей цмфры нет");
   else
   Console.Write($"Третья цифра-> {num % 10}");
 
 if (num>=1000)
 while (num <= 3)
    {
       count=num % 10;
       
    }
    Console.Write($"Третья цифра-> {count }");

    

// else
// Console.Write("Некорректное значение");

// int outputthirddigit = OutputThirdDigit(num);
// Console.Write($"Третье число -> {outputthirddigit} ");
// int OutputThirdDigit(int number)
// {
//     if (number<=100)
//    return number ("Третьей цифры нет");
//    else
//    if (number>=1000)
//     while(number)
// int result = number % 10;
// return result;
// }