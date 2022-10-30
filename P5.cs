using System;


namespace P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Indroduceti cifra");
            int k=int.Parse(Console.ReadLine());
            for (int i = 1; i < k; i++)
                n /= 10;
            Console.WriteLine(n % 10);
        }
    }
}
