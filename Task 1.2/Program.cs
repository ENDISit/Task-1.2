using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            deposit += deposit * 0.07m;
        }

        Console.WriteLine($"Конечная сумма вклада: {deposit}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
