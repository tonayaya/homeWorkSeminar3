//  Задача 19  Напишите программу, которая принимает на вход 
//  пятизначное число и проверяет, является ли оно палиндромом.
//  14212 -> нет
//  12821 -> да
//  23432 -> да

Console.WriteLine("Введите пятизначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);

void Palindrome(int num)
{
    int temp = num;
    int reverseNum = 0;
    while (temp > 0)
    {
        int digit = temp % 10;
        reverseNum = reverseNum * 10 + digit;
        temp = temp / 10;
    }
    if (num == reverseNum) Console.WriteLine($"Число {num} является палиндромом");
    else Console.WriteLine($"Число {num} не является палиндромом");
}
