using System;


namespace P11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.Write(n % 10 + " ");
                n /= 10;
            }
        }
    }
}
