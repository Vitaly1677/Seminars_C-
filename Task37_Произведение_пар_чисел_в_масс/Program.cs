// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[]{1,2,3,4,5,6,7};
PrintArray(array);
Console.Write(" -> ");
PrintArray(MultipliElementArray(array));

Console.WriteLine("");

int[] MultipliElementArray(int[] arr)
{
    int sizeNewArr = 0;
    if (arr.Length %2 == 0) sizeNewArr = arr.Length / 2;
    else sizeNewArr = arr.Length / 2 +1;

    int[] newArr = new int[sizeNewArr];

    for (int i = 0; i < sizeNewArr; i++)
     {
        if (i > arr.Length) newArr[i] = arr[i]*arr[arr.Length-i];
        else newArr[i] = arr[i];
     }
    return newArr;
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