// 12. Напишите программу, которая будет 
// принимать на вход два числа и 
// выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа 
// выводит остаток от деления. 
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите 1-e число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-e число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int remainder = firstNumber % secondNumber;
if (remainder == 0) Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно");
else Console.WriteLine($"{firstNumber}, {secondNumber} -> {remainder}");