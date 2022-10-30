using System;


namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 variabile");
            int a, b, c;
            Console.Write("a = ");
            a=int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b=int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c=int.Parse(Console.ReadLine());
            Console.WriteLine("Avem ecuatia : {0}x^2+{1}x+{2}", a, b, c);
            int delta = b*b-4*a*c;
            if(delta<0)
                Console.WriteLine("Ecuatia nu are solutii");
            else
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(delta))/2*a;
                x2 = (-b - Math.Sqrt(delta))/2*a;
                Console.Write("X1 = " + x1 + " " + "X2= " + x2);
            }

        }
    }
}
