using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 10.Skaičių daugyba iki tam tikros ribos
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());

            while(skaicius <= 1000)
            {
                skaicius = skaicius * 2;
                Console.Write($"{skaicius} ");
            }
        }
    }
}