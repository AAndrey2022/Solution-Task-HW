// Напишите программу, которая:
// - принимает на вход координаты двух точек и 
// - находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки А (x1): ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A (y1): ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки A (z1): ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B (x1): ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B (y1): ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B (z1): ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    int c1 = xa - xb;
    int c2 = ya - yb;
    int c3 = za - zb;
    double result = Math.Sqrt(c1 * c1 + c2 * c2 + c3 * c3);
    double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
    return resultRound;
}
Console.Write($"Расстояние между точками А и В -> {distance}");
