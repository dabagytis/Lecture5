using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 13.Skaičių kvadratų spausdinimas
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());
            double square = 0;

            for(double i = 1; i <= skaicius; i++)
            {
                square = Math.Pow(i, 2);
                Console.WriteLine(square);
                Console.WriteLine();

                if(square > 200)
                {
                    break;
                }
            }

        }
    }
}