﻿using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 5. Skaičių daugybos lentelė
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                int result = skaicius * i;

                if (result > 50)
                {
                    break;
                }

                Console.WriteLine($"{skaicius} x {i} = {result}");
            }
        }
    }
}