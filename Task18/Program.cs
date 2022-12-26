//Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = Coordinates(quarter) != "Err"
                ? $"Диапазон возможных координат точек в четверти {quarter} -> {Coordinates(quarter)}"
                : "Введены некорректные данные.";
Console.WriteLine(result);

string Coordinates(int qurt)
{
    if (quarter == 1) return "xc > 0, yc > 0";
    if (quarter == 2) return "xc < 0, yc > 0";
    if (quarter == 3) return "xc < 0, yc < 0";
    if (quarter == 4) return "xc > 0, yc < 0";
    return "Err";
}