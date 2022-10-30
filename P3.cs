using System;


namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere ");
            Console.Write("n = ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k=int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("{0} se divide cu {1}", n, k);
            else
                Console.WriteLine("{0} nu se divide cu {1}", n, k);
        }
    }
}
