using System;
using System.Collections.Generic;

namespace Classi5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student z;
            Random rnd = new Random();
            int s;
            int g = 0;
            for (int i = 0; i < s.Count; i++)
            {
                int r = rnd.Next(1, 2);
                if (r == 1)
                {
                    z = new Boy();
                    s = z.DoExercise();
                    if (s >= 20)
                    {
                        g++;
                    }
                }
                else
                {
                    z = new Girl();
                    s = z.DoExercise();
                    if (s >= 20)
                    {
                        g++;
                    }
                }
                Console.WriteLine(g + " человек сдал(и) зачёт");

            }

        }
    }
}

