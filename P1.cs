using System;

namespace P1
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere a si b ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Avem ecuatia {0}x+{1}=0", a, b);
            double x=(double)(-b/a);
            Console.WriteLine("x = {0}", x);

        }
    }
}