// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = CreateArrayRndInt(10, 1, 100);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число от 0 до 100 для поиска в указанном выше массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(array);
Console.Write(" -> ");

Console.WriteLine(FindInArray(array,num) ? "Да":"Нет");

bool FindInArray(int[] arr, int findNum)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNum) return true;
    }
    return false;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

