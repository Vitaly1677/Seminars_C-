// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число, для генерации чисел Фибоначчи: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write($"Если N = {count} -> ");
PrintArray(CreateFibArray(0, 1, count));
int[] CreateFibArray(int num1, int num2, int count)
{
    int[] arr = new int[count];
    arr[0] = num1;
    arr[1] = num2;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine();
}