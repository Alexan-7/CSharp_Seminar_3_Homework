// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
while(true)
{
    Console.WriteLine("Введите целое пятизначное число: ");
    int n = int.Parse(Console.ReadLine());

    if (n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else if (n < 10000 || n > 100000)
    {
        Console.WriteLine("Число не является пятизначным");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }

}
