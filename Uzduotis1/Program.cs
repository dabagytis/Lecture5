using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Skaičių teigiamumas/neigiamumas
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                int skaicius = int.Parse(Console.ReadLine());

                if (skaicius > 0)
                {
                    Console.WriteLine("Teigiamas");
                    Console.WriteLine();
                }
                else if (skaicius < 0)
                {
                    Console.WriteLine("Neigiamas");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}