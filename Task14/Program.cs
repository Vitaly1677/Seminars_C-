// 14. Напишите программу, которая 
// принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23. 
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число, для проверки на кратность 7 и 23: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BothMultiple(number) ? "Да" : "Нет");
bool BothMultiple(int num, int div1 = 7, int div2 = 23)
{
 return num % div1 ==0 && num % div2 == 0;
}
