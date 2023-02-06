// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Пример для вычисления факториала
// int FactorialFor(int n)
// {
// int result = 1;
// for (int i = 1; i <= n; i++) result *= i;
// return result;
// }
// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));
int SumDigits(int num){ if (num == 0) return num; 
else return num%10 + SumDigits(num/10); }