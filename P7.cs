using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere");
            Console.Write("a = ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b=int.Parse(Console.ReadLine());
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
