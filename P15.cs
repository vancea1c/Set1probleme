using System;


namespace P15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere");
            string[] t = Console.ReadLine().Split(' ');
            int[] numere=new int[4];
            for(int i=1; i<=3; i++)
                numere[i] = int.Parse(t[i-1]);
            Array.Sort(numere);
            for(int i=1; i<=3; i++)
                Console.Write(numere[i]+" ");
            
        }
    }
}
