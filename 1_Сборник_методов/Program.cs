// Сборник методов

// Вывести массив из целых чисел в терминал
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

// Создать массив int случайными числами
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

// Заполнить массив Int случайными числами
void FillArray(int[] arr,int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
}

//Читает значения из терминала
int ReadIntNumder(int index) 
{
    Console.Write($"Введите число номер {index}: ");
    return Convert.ToInt32(Console.ReadLine());
}

// Проверка int на положителные
bool CheckPositivelIntNumber(int num)
{
    return num > 0;
}

// Разворот массива
void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

// Разворот массива версия 2
void ReverseArrayVersion2(int[] arr)
{
    int index1=0;
    int index2=arr.Length-1;
    while (index1<index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        array[index2] = temp;
        index1++;
        index2--;
    }
}

// Создать массив из Double
double[] CreateArrayRndDouble(int size, int multiplier)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*multiplier;
    }
    return arr;
}

// Вывести массив Double
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) 
        {
        Console.Write("{0,8:N1}", arr[i]);
        Console.Write("; ");
        }
        else Console.Write("{0,8:N1}", arr[i]);
    }
    Console.WriteLine("]");
}

