using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 9. Vartotojo įvesties analizė

            while (true)
            {
                Console.WriteLine("Iveskite skaiciu");
                int skaicius = int.Parse(Console.ReadLine());

                if(skaicius > 0)
                {
                    Console.WriteLine($"Skaicius {skaicius} yra teigiamas");
                    Console.WriteLine();
                }
                else if(skaicius < 0)
                {
                    Console.WriteLine($"Skaicius {skaicius} yra neigiamas");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ivedete 0, programa issijungia");
        }
    }
}