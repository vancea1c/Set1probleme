using System;


namespace P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un an");
            int an=int.Parse(Console.ReadLine());
            if (an % 4 == 0)
                Console.WriteLine("Anul este bisect");
            else
                Console.WriteLine("Anul nu este bisect");
        }
    }
}
