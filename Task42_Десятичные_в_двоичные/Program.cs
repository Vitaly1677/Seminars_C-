// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число, которое будет преобразовано в двоичное: ");

int decNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConvertDecToBin(decNumber));

string ConvertDecToBin(int num)
{
    string binString = string.Empty;
    while (num > 0)
    {
        binString = num % 2 + binString;
        num = num / 2;
    }
    return binString;
}