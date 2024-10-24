using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 4. Skaičių kategorijos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                int skaicius = int.Parse(Console.ReadLine());

                switch (skaicius)
                {
                    case > 0 and <= 10:
                        Console.WriteLine($"{skaicius} yra mazas skaicius");
                        Console.WriteLine();
                        break;
                    case > 10 and <= 100:
                        Console.WriteLine($"{skaicius} yra vidutinis skaicius");
                        Console.WriteLine();
                        break;
                    case > 100:
                        Console.WriteLine($"{skaicius} yra didelis skaicius");
                        Console.WriteLine();
                        break;
                    case < 0:
                        Console.WriteLine($"{skaicius} yra neigiamas skaicius");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine($"Pasirinkote nuline reiksme");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}