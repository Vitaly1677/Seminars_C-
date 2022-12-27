// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число (N) для выдачи таблицы квадратов чисел от 1 до N");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0; 

while (i > number)
{
    Console.WriteLine(Square(number));
    i++;
}

int Square(int num)
{
    return  num * num;
}