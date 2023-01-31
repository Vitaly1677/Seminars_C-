// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

int[,] matrix = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.WriteLine("Начальный массив");
PrintArray(matrix);
MatrixProcessing(matrix);

Console.WriteLine("Новый массив");
PrintArray(matrix);
MatrixProcessing(matrix);

void MatrixProcessing(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (NumEven(i) && NumEven(j)) matr[i, j] = matr[i, j] *= matr[i, j];
        }
    }
}

bool NumEven(int num)
{
    return num % 2 == 0;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("]");
    }
}
