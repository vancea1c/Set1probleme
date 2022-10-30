using System;


namespace P18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            functie(n);
        }
        static void functie(int n)
        {
            int d = 2;
            while(n > 1)
            {
                int p = 0;
                while (n % d == 0)
                {
                    n /= d;
                    p++;
                }
                if (p != 0 && n!=1)
                    Console.Write("{0}^{1}x", d, p);
                else
                    if(p != 0)
                        Console.Write("{0}^{1}", d, p);
                d++;
                if (d * d > n)
                    d = n;
            }

        }
    }
}
