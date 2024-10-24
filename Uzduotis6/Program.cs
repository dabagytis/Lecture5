using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 6. Lyginių skaičių radimas
            for(int i = 0; i <= 50; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}