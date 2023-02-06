/* Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, 
и возводит число А в целую степень B 
с помощью рекурсии.
A = 3; 
B = 5 -> 243 (3⁵)
A = 2; 
B = 3 -> 8 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree < 0) Console.WriteLine("Ошибка ввода степени.");
else Console.WriteLine(MathPow(number,degree)); 


int MathPow(int num, int deg)
{
    if (deg == 0) return 1;
    else return num * MathPow(num, deg - 1);
}