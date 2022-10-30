using System;
using System.ComponentModel.DataAnnotations;

namespace P21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nrrnd(1, 100);

        }


        static void nrrnd(int min, int max)
        {
            Random random = new Random();

            int nr = random.Next(min, max);

            Console.WriteLine("Avem intervalul [{0},{1}]", min, max);
            Console.WriteLine("Numarul tau este {0}", nr);

            string raspuns = Console.ReadLine();

            switch (raspuns)
            {
                case "da":
                    Console.WriteLine("Bine pa");
                    break;
                case "nu":
                    Console.WriteLine("Numarul tau este mai mare sau mai mic decat {0}", nr);
                    raspuns = Console.ReadLine();
                    switch (raspuns)
                    {
                        case "mai mare":
                            nrrnd(nr+1,max);
                            break;

                        case "mai mic":
                            nrrnd(min, nr-1);
                            break;
                    }
                    break;
            }
        }
    }   
}

