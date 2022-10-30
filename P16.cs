using System;


namespace P16
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 5 numere");
            int a, b, c, d, e;
            string[] t=Console.ReadLine().Split(' ');
            a=int.Parse(t[0]);
            b=int.Parse(t[1]);
            c=int.Parse(t[2]);
            d=int.Parse(t[3]);
            e=int.Parse(t[4]);
            int p1 = Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))));
            int p5 = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
            Console.Write(p1 + " ");
            for (int i = p1 + 1; i < p5; i++)
                if (i == a || i == b || i == c || i == d)
                    Console.Write(i + " ");
            Console.Write(p5);
        }
    }
}
