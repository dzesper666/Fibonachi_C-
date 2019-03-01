using System;

class Program
{
    static void Main(string[] args)
    {
        int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        Console.WriteLine("Wprowadź liczbę:");
        string kacperLiczbaWstringu = Console.ReadLine();
        int kacperInt = Int16.Parse(kacperLiczbaWstringu);

        Console.WriteLine();
        Console.WriteLine("Wartość " + kacperInt + " elementu w ciągu Fibonachiugo wynosi:");
        Console.WriteLine(Fibonacci(kacperInt));

    }
}