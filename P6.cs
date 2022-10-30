using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            if (a + b >= c && b + c >= a && a + c >= b)
            {
                Console.WriteLine("Numerele pot fi laturile unui triunghi");
            }
            else
                Console.WriteLine("Numerele nu pot fi laturile unui triunghi");
        }
    }
}
