// 11. Напишите программу, которая 
// выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа. 
// 456 -> 46 
// 782 -> 72 
// 918 -> 98

int randomNumber = new Random().Next(100, 1000);
int firstNumber = (randomNumber - randomNumber % 100) / 100;
int thirdNumber = randomNumber % 100 % 10;
Console.WriteLine($"{randomNumber} -> {firstNumber}{thirdNumber}");