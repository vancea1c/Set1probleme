using System;


namespace P8 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
