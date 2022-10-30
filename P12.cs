using System;


namespace P12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un interval");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    Console.Write(i + " ");
            }

        }
    }
}
