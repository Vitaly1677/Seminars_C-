// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int multiplyNumber = MultiplyNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {multiplyNumber}");

int MultiplyNumber(int count)
{
    int num = 1;
    for (int i = 1; i <= count; i++)
    {
        num *= i;
    }
    return num;
}