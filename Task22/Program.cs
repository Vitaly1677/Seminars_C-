// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число (N) для выдачи таблицы квадратов чисел от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) TableSquare(number);
else System.Console.WriteLine("Введено не натуральное число.");

void TableSquare(int num)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 5}  {Math.Pow(count, 2), 5}");
        count++;
    }
}