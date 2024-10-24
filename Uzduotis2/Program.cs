using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 2. Kelių skaičių palyginimas
            int didziausias = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                int skaicius = int.Parse(Console.ReadLine());
                if(skaicius > didziausias)
                {
                    didziausias = skaicius;
                }
            }
            Console.WriteLine($"Didziausias skaicius yra {didziausias}");
        }
    }
}