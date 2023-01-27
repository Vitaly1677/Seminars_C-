// Задача 45: Напишите программу, 
// которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.
int[] arrayOrig = new int[10]; // Исходный массив
int[] arrayCopy = new int[10]; // Массив для копирования

FillArray(arrayOrig, 10, 100);

PrintArray(arrayOrig);
PrintArray(arrayCopy);
CopyArrayToArray(arrayOrig, arrayCopy);
PrintArray(arrayOrig);
PrintArray(arrayCopy);

void FillArray(int[] arr,int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
}

void CopyArrayToArray(int[] arrOrig, int[] arrCopy)
{
    for (int i = 0; i < arrOrig.Length; i++)
    {
        arrCopy[i] = arrOrig[i];
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}