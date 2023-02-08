// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!)!;
int num1 = num;
int num_rev = 0;
int b = 0;

while (num > 0)
{
    b = num % 10;
    num = num / 10;
    num_rev = b + (num_rev * 10);
}
if (num_rev == num1)
{
    Console.WriteLine("Ваше число - ПАЛИНДРОМ!");
}
else
{
    Console.WriteLine("Ваше число - НЕ палиндром!");
}