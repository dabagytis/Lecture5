using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 3. Skaičių lyginumas / nelyginumas
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                int skaicius = int.Parse(Console.ReadLine());

                int a = skaicius % 2;

                switch (a)
                {
                    case 0:
                        Console.WriteLine($"Skaicius {skaicius} yra lyginis");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine($"Skaicius {skaicius} yra nelyginis");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}