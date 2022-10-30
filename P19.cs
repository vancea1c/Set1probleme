using System;


namespace P19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int[] f = new int[10];
            while (n > 0)
            {
                f[n % 10] = 1;
                n /= 10;
            }
            int suym = 0;
            foreach (int i in f)
                suym += f[i];
            if (suym == 2)
                Console.WriteLine("Numarul introdus este format doar din doua cifre");
            else
                Console.WriteLine("Numarul introdus este format din mai mult de doua cifre");


        }
    }
}