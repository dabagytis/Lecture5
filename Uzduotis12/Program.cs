using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 12. Sekos augimas pagal vartotojo sąlygą
            Console.WriteLine("Iveskite skaiciu:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite prieaugi:");
            int b = int.Parse(Console.ReadLine());

            while (a < 500)
            {
                a = a + b;

                if(a % 2 == 0)
                {
                    a = a * 2;
                    Console.WriteLine($"{a}");
                }
            }
        }
    }
}