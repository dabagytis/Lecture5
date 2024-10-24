using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 15. Aritmetinė progresija
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite prieaugi:");
            int prieaugis = int.Parse(Console.ReadLine());

            for(int i = 0; i < 50; i++)
            {
                skaicius = skaicius + prieaugis;
                Console.Write($"{skaicius} ");

                if(skaicius > 100)
                {
                    break;
                }
            }
        }
    }
}