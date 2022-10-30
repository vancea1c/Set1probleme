using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar");
            int n=int.Parse(Console.ReadLine());
            int ogl = 0;
            int cn = n;
            while (cn>0)
            {
                ogl = ogl * 10 + cn % 10;
                cn /= 10;
            }
            if (ogl == n)
                Console.WriteLine("Numarul {0} este palindrom", n);
            else
                Console.WriteLine("Numarul {0} nu este palindrom", n);
        }
    }
}
