// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты двух точек для нахождения расстояния между ними в 2D пространстве");
Console.Write("XA :");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA :");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("XB :");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB :");
int yb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, ya, xb, yb), 2, MidpointRounding.ToZero);
Console.WriteLine ($"Distance between segment with coordinates {xa}, {xb} и {ya}, {yb} -> {ourDistance}");

double Distance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2)));
    return distance;
}