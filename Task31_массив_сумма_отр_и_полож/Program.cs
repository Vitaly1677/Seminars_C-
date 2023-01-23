// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 

// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна   29, 
// сумма отрицательных равна        -20.

int[] array = CreateArray(12,-9,9);
PrintArray(array);
int[] CreateArray(int size, int rndBegin, int rndEnd)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(rndBegin, rndEnd);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != 0) Console.Write(", ");
        Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}