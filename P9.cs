using System;


namespace P9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un nr:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.Write(i + " ");
        }
    }
}
