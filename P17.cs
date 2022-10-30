using System;


namespace P17
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
            int ca = a;
            int cb = b;
            while(cb != 0)
            {
                int r = ca % cb;
                ca = cb;
                cb = r;
            }
            Console.WriteLine("Cel mai mare divizor comun al numerelor {0} si {1} este {2}", a, b, ca);
            Console.WriteLine("Cel mai mic multiplu comul al numerelor {0} si {1} este {2}", a, b, (a * b) / ca); 

        }
    }
}
