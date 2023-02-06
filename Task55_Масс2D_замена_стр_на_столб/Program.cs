// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


// void ChangeRowColumnsMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0)-1; i++)
// {
// for (int j = i+1; j < matrix.GetLength(1); j++)
// {
// int temp = matrix[i, j];
// matrix[i, j] = matrix[j, i];
// matrix[j, i] = temp;
// }
// }
// }

// /*int[,] ChangeRowColumnsMatrix(int[,] matrix)
// {
// int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// newMatrix[i, j] = matrix[j, i];
// }
// }
// return newMatrix;
// }*/