using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 7. Atsitiktinių skaičių skaičiavimas
            Random r = new Random();
            int skaicius = 0;
            int count = 0;

            while (skaicius != 7)
            {
                skaicius = r.Next(1, 11);
                Console.WriteLine(skaicius);
                count++;
            }

            Console.WriteLine($"Sugeneruotu skaiciu kiekis: {count}");
        }
    }
}