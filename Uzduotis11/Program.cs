using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 11.Skaičių pirminumas

            for(int i = 2; i <= 50; i++)
            {
                bool x = true;
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        x = false;
                        break;
                    }
                }

                if(x)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}