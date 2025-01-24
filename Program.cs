using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Да, одно из чисел является делителем другого");
        }
        else
        {
            Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
        }
    }
}