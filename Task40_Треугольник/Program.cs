// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите 3 числа для проверки, может ли существовать треугольник со сторонами такой длины");
int a = ReadIntNumder(1);
int b = ReadIntNumder(2);
int c = ReadIntNumder(3);

Console.WriteLine(IsExistTriangle(a, b, c) ? "Треугольник может существовать." : "Треугольник не может существовать.");

bool IsExistTriangle(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}

int ReadIntNumder(int index)
{
    Console.Write($"Введите число номер {index}: ");
    return Convert.ToInt32(Console.ReadLine());
}