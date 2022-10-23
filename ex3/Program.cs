//  Задача 23 Напишите программу, которая принимает на вход
//  число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  3 -> 1, 8, 27
//  5 -> 1, 8, 27, 64, 125

void TableSqrt(int N)
{   
    for(int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
Console.Write("Введите целое число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tаблица кубов чисел от 1 до N: ");
TableSqrt(num);