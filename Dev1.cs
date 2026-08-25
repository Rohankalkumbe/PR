using System;

// Fibonacci Series in C# Program

class Program
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int first = 0;
        int second = 1;




        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
    }
}