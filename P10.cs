using System;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());

            if (nrprim(n))
                Console.WriteLine("Este prim");
            else
                Console.WriteLine("Nu este prim");
        }
        public static bool nrprim(int n)
        {
            int nrdiv = 1;
            int d = 2;
            while (n > 1)
            {
                int p = 0;
                while (n % d == 0)
                {
                    n /= d;
                    p++;
                }
                nrdiv = nrdiv * (p + 1);
                d++;
                if (d * d > n)
                    d = n;
            }
            return nrdiv == 2;
        }
    }
}