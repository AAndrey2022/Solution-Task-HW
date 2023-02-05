// Напишите программу, которая:
// - найдёт точку пересечения двух прямых, 
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Ведите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double intersectionPointLinesX = IntersectionPointLinesX(b1, k1, b2, k2);
double intersectionPointLinesY = IntersectionPointLinesY(b1, k1, b2, k2);
Console.Write($"b1 = {b1}, k1 = {k1},b2 = {b2}, k2 = {k2} -> ");
Console.Write($"({Math.Round(intersectionPointLinesX, 2, MidpointRounding.ToZero)}; ");
Console.Write($"{Math.Round(intersectionPointLinesY, 2, MidpointRounding.ToZero)})");

double IntersectionPointLinesX(int b1, int k1, int b2, int k2)
{
    double res1 = b1 - b2;
    double res2 = k2 - k1;

    double x = res1 / res2;
    return x;
}

double IntersectionPointLinesY(int b1, int k1, int b2, int k2)
{
    double res1 = b1 - b2;
    double res2 = k2 - k1;

    double x = res1 / res2;
    double y = k2 * x + b2;
    return y;
}

// Math.Round(intersectionPointLinesX, 2, MidpointRounding.ToZero);
// Math.Round(intersectionPointLinesY, 2, MidpointRounding.ToZero);