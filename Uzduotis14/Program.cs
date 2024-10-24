using System;
using System.ComponentModel.DataAnnotations;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 14.Kiek skaitmenų yra skaičiuje
            Console.WriteLine("Iveskite teigiama skaiciu:");
            float skaicius = float.Parse(Console.ReadLine());
            float skaitmenys = 0;
            int test = 10;

            while (true)
            {
                skaitmenys = skaitmenys + 1;

                if(skaicius / test < 1)
                {
                    break;
                }

                test = test * 10;
            }
            Console.WriteLine($"Skaicius {skaicius} turi {skaitmenys} skaitmenis");
        }
    }
}