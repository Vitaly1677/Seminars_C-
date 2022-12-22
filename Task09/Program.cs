// 9. Напишите программу, которая 
// выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа. 
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randomNumber = new Random().Next(10, 100);
int secondNumber = randomNumber % 10;
int firstNumber = (randomNumber - secondNumber) / 10;
if (secondNumber > firstNumber) Console.WriteLine($"{randomNumber} -> {secondNumber}");
else Console.WriteLine($"{randomNumber} -> {firstNumber}");